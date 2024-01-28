
Module Program
    Sub Main(args As String())
        Dim num1, num2, sum As Integer

        Console.WriteLine("Add two Numbers")
        Console.WriteLine("With .Net 6")
        Console.WriteLine("Input the first number.")
        num1 = Console.ReadLine()
        Console.WriteLine("Input the second number.")
        num2 = Console.ReadLine()

        sum = num1 + num2

        Console.Write("The sum of the two numbers is ")
        Console.Write(sum)
        Console.ReadLine()
    End Sub
End Module
