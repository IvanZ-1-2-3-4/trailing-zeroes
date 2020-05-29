Module Module1

    Sub Main()
        Dim answer As Integer
        Dim out As Integer
        Dim i As Integer = 1
        While (True)
            Console.WriteLine("Input number: ")
            answer = Console.ReadLine()
            out = 0
            i = 1
            While ((answer / 5 ^ i) > 1)
                out = out + (Math.Floor(answer / (5 ^ i)))
                i = i + 1
            End While

            Console.WriteLine(out)
        End While
    End Sub

End Module
