Module Module1

    Sub Main()
        Dim str1, impStr, str2 As String
        impStr = "ing"
        str1 = ""
        str2 = ""


        Console.Write("Enter the string to prcess: ")
        str1 = Console.ReadLine()

        If Len(str1) < 3 Then
            Console.Write(str1)
            Console.ReadKey()
            End
        End If

        str2 = Mid(str1, ((Len(str1) - 3) + 1), 3)

        If str2 = impStr Then
            str1 = str1 + "ly"
        Else
            str1 = str1 + impStr
        End If

        Console.Write("The processed string is: " & str1)
        Console.ReadKey()
    End Sub

End Module
