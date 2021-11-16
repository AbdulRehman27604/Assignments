Module Module1

    Sub Main()
        Dim donuts As Integer
        donuts = 0
        Console.WriteLine("Numbers of donuts")
        donuts = Console.ReadLine
        If donuts <= 5 Then
            Console.WriteLine("less")
        ElseIf donuts >= 10 Then
            Console.WriteLine("many")
        End If
        Console.ReadKey()
    End Sub

End Module
