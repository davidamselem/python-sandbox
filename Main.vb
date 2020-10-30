Imports System.IO


'////
Module Main

    '//
    Const CONST_ROOT = ""

    '/**/
    Sub Main()



        '//
        Dim args() As String = Nothing

        '//
        Dim id As Integer

        '//
        Dim binaryPath As String



        '//
        binaryPath = CONST_ROOT + "nw.exe"



        '//
        If (hasArguments(args)) Then

            '//
            binaryPath += " " + args(1)

            '//
            For i = 2 To args.Length - 1 'For Each arg As String In args

                '//
                Dim sourcePath = args(i)
                Dim sourceFile = Path.GetFileName(sourcePath)

                '//
                Directory.CreateDirectory(CONST_ROOT + "include\temp")

                '//
                Dim targetPath = CONST_ROOT + "include\temp\" + sourceFile

                '//
                File.Copy(sourcePath, targetPath, True)

                '//
                Dim localFile = "/include/temp/" + sourceFile

                '//
                binaryPath += " " + localFile

                '//
                'Console.WriteLine(arg)

            Next

        End If



        '//
        id = Shell(binaryPath, AppWinStyle.NormalFocus)



        '//
        'Console.WriteLine("Shell ID: " + id.ToString)

        '//
        'Console.WriteLine("Press any key to exit.")

        '//
        'Console.ReadKey()



    End Sub

    '/**/
    Function hasArguments(ByRef args() As String) As Boolean

        '//
        args = System.Environment.GetCommandLineArgs()

        '//
        If (args.Length > 1) Then

            '//
            Return True

        Else

            '//
            Return False

        End If

    End Function

End Module
