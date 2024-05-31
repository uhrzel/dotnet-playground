Imports System

Module Program
    Sub Main()

        Dim num() as Integer = {1,2,3,4,5}

        For Each i As Integer in num
            Console.writeLine(i)
        Next

        Console.Readkey()
    End Sub
End Module
