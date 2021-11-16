Module Module1

    Sub Main()

        Dim str1 As String
        Dim X, count, count2, count3 As Integer
        Dim char1, highdigit, lowdigit, t, p As Char
        str1 = ""
        X = 0
        count = 0
        count2 = 0
        count3 = 0
        highdigit = "0"
        lowdigit = "9"
        t = " "
        p = "\"

        Console.WriteLine("ENTER A STRING ")
        str1 = UCase(Console.ReadLine)
        For X = 1 To Len(str1)
            char1 = Mid(str1, X, 1)
            If char1 >= "A" And char1 <= "Z" Then
                count = count + 1
            ElseIf Asc(char1) >= 32 And Asc(char1) <= 47 Then
                count2 = count2 + 1


            ElseIf char1 >= "0" And char1 <= "9" Then
                count3 = count3 + 1

            End If
        Next

        Console.WriteLine("NUMBER OF ALPHABATS ARE:" & count)
        Console.WriteLine("NUMBER OF SPECIAL CHARACTERS ARE:" & count2)
        Console.WriteLine("NUMBER OF DIGITS ARE:" & count3)
        Console.ReadKey()
    End Sub

End Module
