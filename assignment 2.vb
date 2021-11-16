Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim thischar, char1, char2 As Char
        Dim count As Integer
        str1 = ""
        str2 = ""
        thischar = ""
        char1 = ""
        char2 = ""
        count = 0
        Console.WriteLine("ENTER STRING:")
        str1 = Console.ReadLine
        Console.WriteLine("ENTER CHARACTER TO FIND:")
        char1 = Console.ReadLine
        Console.WriteLine("ENTER CHARACTER TO REPLACE:")
        char2 = Console.ReadLine
        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If thischar = char1 Then
                str2 = str2 & char2
            Else : str2 = str2 & thischar
            End If


        Next
        Console.WriteLine("PROCESSED STRING) = " & str2)

        Console.ReadKey()

    End Sub

End Module
