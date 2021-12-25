Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim isPangram As Boolean
        Dim Str1Char, Str2Char As Char

        Console.ReadLine()
        Str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Str2 = UCase("A quick brown fox jumps over the lazy dog")

        Console.WriteLine("Enter Str2: ")


        If isPangram = True Then

            Console.WriteLine("Str2 is Pangram")
        Else
            Console.WriteLine("Str2 is Not Pangram")


        End If
        Console.ReadLine()


    End Sub

End Module
