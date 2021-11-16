Module Module1

    Sub Main()
     
        Dim Str1 As String
        Dim str2 As String
        Dim pangram As Boolean
        Dim thischar, char1 As Char
        Dim x As Integer
        Dim chrplace As Integer
        Str1 = ""
        str2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        pangram = True
        thischar = ""
        x = 0
        char1 = ""
        chrplace = 0
        Console.Write("Enter a string: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        For x = 1 To Len(str2)
            thischar = Mid(str2, x, 1)
            chrplace = InStr(Str1, thischar)

            If chrplace = 0 Then
                pangram = False
                Exit For
            End If
        Next
        If pangram = True Then
            Console.Write("The Entered string contain all the alphabets")
        Else
            Console.Write("Entered string does not contain all alphabets")
        End If
        Console.ReadKey()
    End Sub
End Module
