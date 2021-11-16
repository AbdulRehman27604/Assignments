Module Module1

    Sub Main()
        Dim STR1 As String
        Dim X, power, power2, power3, power4, power5, counter As Integer
        Dim char1 As Char
        STR1 = ""
        Console.WriteLine("ENTER A STRING TO PROCESS")
        STR1 = UCase(Console.ReadLine)
        For X = 1 To Len(STR1)
            char1 = Mid(STR1, X, 1)
            If char1 = "A" Then
                power = power + 1
            ElseIf char1 = "E" Then
                power2 = power2 + 1
            ElseIf char1 = "O" Then
                power3 = power3 + 1
            ElseIf char1 = "I" Then
                power4 = power4 + 1
            ElseIf char1 = "U" Then
                power5 = power5 + 1
            End If
        Next
        Console.WriteLine("VOWEL 'A' is" & power)
        Console.WriteLine("VOWEL 'E' is" & power2)
        Console.WriteLine("VOWEL 'I' is" & power4)
        Console.WriteLine("VOWEL 'O' is" & power3)
        Console.WriteLine("VOWEL 'U' is" & power5)
        counter = power + power2 + power3 + power4 + power5
        Console.WriteLine("TOTAL VOWELS ARE :" & counter)
        Console.ReadKey()
    End Sub

End Module
