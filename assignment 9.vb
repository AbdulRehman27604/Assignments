Module Module1

    Sub Main()
        Dim str1, str2, str3, str4 As String
        Dim c1, c2 As Integer
        Dim chr1, chr2, thischr1, thischr2 As Char

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        c1 = 0
        c2 = 0
        chr1 = ""
        chr2 = ""
        thischr1 = ""
        thischr2 = ""


        Console.Write("Enter the first word: ")
        str1 = Console.ReadLine()
        Console.Write("Enter the second word: ")
        str2 = Console.ReadLine()

        chr1 = Left(str1, 1)
        chr2 = Left(str2, 1)

        str3 = chr2
        str4 = chr1
        For c1 = 2 To Len(str2)
            thischr1 = Mid(str2, c1, 1)
            str4 = str4 + thischr1

        Next

        For c2 = 2 To Len(str1)
            thischr2 = Mid(str1, c2, 1)
            str3 = str3 + thischr2

        Next

        Console.Write("The processed string is: " & str3 & " " & str4)
        Console.ReadKey()
    End Sub

End Module
