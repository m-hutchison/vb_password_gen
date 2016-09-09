Public Class Form1
    '**************************************************************************************************'
    '** This program was made by Mathew Hutchison                                                    **'
    '** The purpose of this program is to generate random characters for any purpose however mainly  **'
    '** using it for password generation. This program is simple yet effective and can go a long way **'
    '**************************************************************************************************'

    Const chars = "!@#$%^&*()ABCDEFGHIJKLMNOPQRSTyvwxyzabcdefghijklmnopqrstyvwxyz123456789" 'Define which chracters are in the program
    Dim pass As String = "pass.txt" 'filename becomes a shortcut'

    Private Sub btnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGen.Click
        'This button when clicked generates the chracters '

        Dim r, i
        Dim x As String = Nothing 'Declaring x as nothing 
        Dim t = Nothing 'Declaring t as nothing

        If rd7.Checked = False And rd12.Checked = False And rd24.Checked = False And rdCust.Checked = False And mskCust.Text = "" Then
            MsgBox("No buttons have been selected!", MsgBoxStyle.Exclamation, "No buttons!") 'Checking if any buttons have been selected'
        Else
            If rd7.Checked = True Then 'If rd7 is checked then the password will be 7 chatacters long'
                t = 7
            ElseIf rd12.Checked = True Then 'If rd12 is checked then the password will be 12 chatacters long'
                t = 12
            ElseIf rd24.Checked = True Then 'If rd24 is checked then the password will be 24 chatacters long'
                t = 24
            ElseIf rdCust.Checked = True Then 'If rdCust is checked then the password will be defined by the user'
                t = Val(mskCust.Text)
            End If

            For i = 1 To t 'i is the same value as the user has selected'
                Randomize() 'Randomize the characters'
                r = Int((Rnd() * 61) + 1)

                x = x & Mid(chars, r, 1) 'x is the output'

            Next i
            txtGen.Text = x 'Display the output in a textbox'
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If txtGen.Text = "" And rd7.Checked = False And rd12.Checked = False And rd24.Checked = False Then
            MsgBox("Form is already cleared!", MsgBoxStyle.Exclamation, "Cannot clear!") 'Checking if form has been cleared'
        Else
            txtGen.Text = "" 'Clear text'
            mskCust.Text = "" 'Clear text'
            rd7.Checked = False 'Clear button'
            rd12.Checked = False 'Clear button'
            rd24.Checked = False 'Clear button'
            rdCust.Checked = False 'Clear button'
            MsgBox("Cleared form!", MsgBoxStyle.Exclamation, "Form cleared!")
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim objWrite As New System.IO.StreamWriter(pass, True)  'objWrite allows the program to write to the reorder log'

        If txtGen.Text = "" Then
            MsgBox("There's nothing to save!", MsgBoxStyle.Exclamation, "No password!")
        Else

            objWrite.WriteLine(DateTime.Now.ToLongDateString() & " " & "@" & " " & TimeOfDay()) 'Displays Date and Time ie. Wednesday 1 June @ 3:29pm'
            objWrite.WriteLine(" ") 'Adds a break after each date entry'
            objWrite.WriteLine("Password:" & " " & txtGen.Text) 'Adds into text file'
            objWrite.WriteLine(" ") 'Adds a break'
            objWrite.WriteLine("------------------------------------") 'Adds a line'
            objWrite.WriteLine(" ") 'Adds a break'

            MsgBox("Password saved!")
        End If
        objWrite.Close()
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFormToolStripMenuItem.Click
        If txtGen.Text = "" And rd7.Checked = False And rd12.Checked = False And rd24.Checked = False Then
            MsgBox("Form is already cleared!", MsgBoxStyle.Exclamation, "Cleared form!") 'Checking if form has been cleared'
        Else
            txtGen.Text = "" 'Clear text'
            mskCust.Text = "" 'Clear text'
            rd7.Checked = False 'Clear button'
            rd12.Checked = False 'Clear button'
            rd24.Checked = False 'Clear button'
            rdCust.Checked = False 'Clear button'
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If txtGen.Text = "" Then
            MsgBox("Cannot copy a blank textbox!", MsgBoxStyle.Exclamation, "Nothing to copy!")
        Else
            Clipboard.SetText(txtGen.Text) 'Copy text from txtGen onto the Windows clipboard'
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show() 'Show About form'
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End 'Close program'
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End 'Close program'
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mskCust.Visible = False
    End Sub

    Private Sub rdCust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdCust.CheckedChanged
        If rdCust.Checked = False Then
            mskCust.Visible = False
        Else
            mskCust.Visible = True
        End If
    End Sub
End Class
