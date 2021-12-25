Module Module1

    Sub Main()
        Dim donutcount As Integer
        donutcount = 0

        Console.WriteLine("Enter the number of donuts: ")
        donutcount = Console.ReadLine()

        If donutcount < 10 Then
            Console.WriteLine("number of donuts: ")
            Console.WriteLine(donutcount)
        ElseIf donutcount >= 10 Then
            Console.WriteLine("number of donuts: many")
        End If


        Console.ReadLine()
    End Sub

End Module
