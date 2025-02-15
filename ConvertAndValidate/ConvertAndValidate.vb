'Jason Permann
'Spring 2025
'RCET2265
'Convert And Validate
'https://github.com/JaceFoxman/ConvertAndValidate.git

Option Explicit On
Option Strict On
Option Compare Text
Module ConvertAndValidate

    Sub Main()
        'testing
        Dim aValidNumber As Integer
        Dim usernResponse As String
        Dim ConversionValid As Boolean = False
        Do
            Console.WriteLine($"Enter a number:")
            usernResponse = Console.ReadLine()

            If ConversionValid(usernResponse, aValidNumber) = True Then
                Console.WriteLine($"{UsernResponse} converted successfully to {aValidNumber}!")
            Else
                Console.WriteLine($"Oops,{usernResponse} does not seem to be a number")
            End If
        Loop
    End Sub

End Module
