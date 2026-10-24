Imports System.Security.Cryptography

Module PasswordSecurity

    Private Const Iterations As Integer = 100000
    Private Const SaltSize As Integer = 16
    Private Const HashSize As Integer = 32

    '==================================================
    ' HASH PASSWORD
    '==================================================
    Public Function HashPassword(
        password As String
    ) As String

        Dim salt(SaltSize - 1) As Byte

        Using rng As RandomNumberGenerator =
            RandomNumberGenerator.Create()

            rng.GetBytes(salt)

        End Using


        Dim hash As Byte()

        Using pbkdf2 As New Rfc2898DeriveBytes(
            password,
            salt,
            Iterations,
            HashAlgorithmName.SHA256
        )

            hash =
                pbkdf2.GetBytes(HashSize)

        End Using


        Return String.Join(
            "$",
            "PBKDF2",
            Iterations.ToString(),
            Convert.ToBase64String(salt),
            Convert.ToBase64String(hash)
        )

    End Function


    '==================================================
    ' VERIFY PASSWORD
    '==================================================
    Public Function VerifyPassword(
        password As String,
        storedPassword As String
    ) As Boolean

        If String.IsNullOrWhiteSpace(storedPassword) Then
            Return False
        End If


        '==============================================
        ' OLD PLAINTEXT PASSWORD
        ' Backward compatibility
        '==============================================
        If Not storedPassword.StartsWith(
            "PBKDF2$",
            StringComparison.Ordinal
        ) Then

            Return String.Equals(
                password,
                storedPassword,
                StringComparison.Ordinal
            )

        End If


        Try

            Dim parts() As String =
                storedPassword.Split("$"c)

            If parts.Length <> 4 Then
                Return False
            End If


            Dim iterations As Integer =
                Integer.Parse(parts(1))

            Dim salt As Byte() =
                Convert.FromBase64String(
                    parts(2)
                )

            Dim storedHash As Byte() =
                Convert.FromBase64String(
                    parts(3)
                )


            Dim calculatedHash As Byte()

            Using pbkdf2 As New Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256
            )

                calculatedHash =
                    pbkdf2.GetBytes(
                        storedHash.Length
                    )

            End Using


            Return CryptographicOperations.FixedTimeEquals(
                calculatedHash,
                storedHash
            )


        Catch

            Return False

        End Try

    End Function


    '==================================================
    ' CHECK IF PASSWORD IS ALREADY HASHED
    '==================================================
    Public Function IsHashedPassword(
        storedPassword As String
    ) As Boolean

        Return Not String.IsNullOrWhiteSpace(
            storedPassword
        ) AndAlso
        storedPassword.StartsWith(
            "PBKDF2$",
            StringComparison.Ordinal
        )

    End Function

End Module