
Module VBConGiveMeYourName
    Sub Main(args As String())
        Dim YourName As String

        Console.WriteLine("This app uses .Net 7")
        Console.WriteLine("My name is Appa")
        Console.WriteLine("")
        Console.WriteLine("What is your name")
        Console.WriteLine("")

        YourName = Console.ReadLine()
        Console.Write("Hi ")
        Console.Write(YourName)
        Console.Write(" How are you doing today?")
        Console.ReadLine()
    End Sub
End Module
