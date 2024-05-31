Imports System

Module Program
    Sub Main()

        Dim arraySize As Integer = 5
        Dim userInputArray(arraySize - 1) As Integer

         For var As Integer = 0 To arraySize - 1
            Console.Write("Enter value for index " & var + 1 & " :")
            userInputArray(var) = Convert.toInt32(Console.ReadLine())
        Next  

        Dim target As Integer = 0
        Console.Write("Enter Target: ")
        target = Convert.toInt32(Console.ReadLine())
        findTarget(userInputArray, arraySize,target)
        
    End Sub

    Function findTarget(ByVal array() As Integer, Byval size As Integer,  ByVal target As Integer) As Integer()
        Dim temp1 As Integer = 0
        Dim temp2 As Integer = 0
        
        For i As Integer = 0 to size - 1
            For x As Integer = 0 to size - 1 
                If array(x) + array(i) = target And i <> x  Then
                    temp1 = x
                    temp2 = i
                End If
            Next 
        Next

        Console.WriteLine("[" & temp1 & "][" & temp2 & "]")
    End Function
End Module
