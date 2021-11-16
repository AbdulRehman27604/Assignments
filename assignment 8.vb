Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim dischar, fchar, char2 As Char
        Dim c1 As Integer

        str1 = ""
        str2 = ""
        dischar = ""
        fchar = ""
        c1 = 0
        char2 = "*"

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine()
        str1 = UCase(str1)
        fchar = Left(str1, 1)
        str2 = fchar

        For count1 = 1 To Len(str1)
            dischar = Mid(str1, count1 + 1, 1)
            If dischar = fchar Then
                str2 = str2 + char2
            Else : str2 = str2 + dischar
            End If
        Next

        Console.Write("The manupilated string is: " & LCase(str2))
        Console.ReadKey()

    End Sub

End Module
