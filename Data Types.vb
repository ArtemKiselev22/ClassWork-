Imports System

Module Program
    Sub Main(args As String())
        'Dim dens As Decimal
        'Dim dubl As Double
        'Dim sig As Single
        'Dim int As Integer
        'dens = 1.2345678900987653
        'dubl = 100.00001
        'sig = 100.00001
        'int = 100
        'Console.WriteLine("desimal = {0}", dens)
        'Console.WriteLine("Double = {0}", dubl)
        'Console.WriteLine("single = {0}", sig)
        'Console.WriteLine("integer = {0}", int)
        Dim SUM As String
        Dim rub As Integer
        Dim qwe As Integer
        Console.WriteLine("Введите сумму с копейками")
        SUM = Console.ReadLine()
        rub = SUM / 100
        Console.WriteLine("ruble = {0}", rub)
        qwe = SUM Mod 100
        Console.WriteLine("Copeiky = {0}", qwe)
    End Sub
End Module
