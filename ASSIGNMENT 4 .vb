Module Module1

    Sub Main()
        Dim c1, c2, c3, highest As Integer
        Dim high1, char1, char2 As Char
        Dim str1 As String
        c1 = 0
        c2 = 0
        c3 = 0
        highest = 0
        high1 = ""
        char1 = ""
        char2 = ""
        str1 = ""
        Console.WriteLine("ENTER A STRING :")
        str1 = Console.ReadLine
        For c1 = 1 To Len(str1)
            char1 = Mid(str1, c1, 1)
            c3 = 0
            For c2 = 1 To Len(str1)
                char2 = Mid(str1, c2, 1)
                If char1 = char2 Then
                    c3 = c3 + 1
                    If c3 > highest Then
                        high1 = char2
                        highest = c3
                    End If
                End If
            Next
        Next
        Console.Write(UCase(high1) & "  is the occuring: " & highest & " times in your string.")
        Console.ReadKey()
    End Sub

End Module
