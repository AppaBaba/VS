
Module Program
    Sub Main(args As String())
        Console.WriteLine("")
        Console.WriteLine("Console Guess Number")
        Console.WriteLine("With .Net 6")
        Console.WriteLine("")

        Call GuessNumber()

        Console.WriteLine("")
        Console.WriteLine("Enter to quit")
        Console.ReadLine()
    End Sub
    Private Sub GuessNumber()
        Dim num, userguess2 As Integer
        Dim i As Integer = 0
        Dim userguess As String
        Dim quit As Boolean = False
        Dim found As Boolean = False

        Randomize()
        num = CInt(Int((10 * Rnd()) + 1))

        Console.WriteLine("I'm going to search a number from 1 to 10. Can you help me ? (0 to quit).")
        Console.WriteLine("")

        While Not (quit Or found)
            i += 1
            Console.Write("Guess -  " & i & ": ")
            userguess = Console.ReadLine()
            Console.WriteLine("")

            Try
                userguess2 = Int32.Parse(userguess)
            Catch
                userguess2 = 0
            End Try

            If userguess2 = 0 Then
                quit = True
            ElseIf userguess2 = num Then
                found = True
            ElseIf userguess2 < num Then
                Console.WriteLine("Too Low, Guess a number that comes after " & CStr(userguess2) & ".")
                Console.WriteLine("")
            ElseIf userguess2 > num Then
                Console.WriteLine("Too High, Guess a number that comes before " & CStr(userguess2) & ".")
                Console.WriteLine("")
            End If

        End While

        If found Then
            Console.WriteLine("You got it right in " & i & " guesses")
        Else
            Console.WriteLine("You gave up!")
        End If
    End Sub
End Module
