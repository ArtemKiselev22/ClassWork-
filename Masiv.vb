Imports System

Module Masiv
    Sub Main(args As String())
        Dim num(6), Mas As Integer

        For i = 1 To num.Length - 1
            num(i) = Console.ReadLine()
        Next


        printRevers(num)

        Dim strings(4) As String

        For i = 1 To strings.Length - 1
            strings(i) = Console.ReadLine()
        Next
        printRevers(strings)
    End Sub
    Sub printRevers(list As Integer())

        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next

    End Sub
    Sub printRevers(list As String())

        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next

    End Sub

End Module
