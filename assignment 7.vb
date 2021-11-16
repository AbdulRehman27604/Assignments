Module Module1

    Sub Main()

        Dim word, letter As String
        Dim x As Integer
        Dim char1, char2, char3, char4 As Char
        word = ""
        Console.WriteLine("ENTER A WORD TO PROCESS")
        word = Console.ReadLine
        For x = 1 To Len(word)
            char1 = Mid(word, 1)
            char2 = Mid(word, 2)
            Exit For
        Next

        For x = 1 To Len(word)
            char3 = Right(word, 1)
            char4 = Right(word, 2)
            Exit For
        Next

        letter = (char1) & (char2) & (char4) & (char3)
        Console.WriteLine(letter)
        Console.ReadKey()
    End Sub

End Module
