Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Public Class MainForm

    Private IsDirtyBoolean As Boolean

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim ResponseDialogResult As DialogResult
        Dim BagelTypeString As String

        Try
            'Open the file

            Dim TypesStreamReader As StreamReader = New StreamReader("BagelType.txt")

            'Read all element into the list

            Do Until TypesStreamReader.Peek = -1
                BagelTypeString = TypesStreamReader.ReadLine()
                BagelComboBox.Items.Add(BagelTypeString)

            Loop
            'Close the file
            TypesStreamReader.Close()

        Catch ex As Exception
            'File missing

            ResponseDialogResult = MessageBox.Show("Create a new file?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ResponseDialogResult = DialogResult.No Then
                'Exit Program
                Me.Close()
            End If

        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the program
        Me.Close()
    End Sub


    Private Sub AddBagelTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddBagelTypeToolStripMenuItem.Click
        'Add a new bagel to the Bagel list
        With BagelComboBox
            'Test for blank input
            If .Text <> "" Then
                'Make sure the item is not already on the list
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer
                Do Until ItemFoundBoolean Or ItemIndexInteger = .Items.Count
                    If .Text = .Items(ItemIndexInteger).ToString() Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Duplicate item.", "Add Failed", _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    'If its not in the list, add it
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Enter a Bagel type to add", "Missing Data", MessageBoxButtons.OK, _
                                MessageBoxIcon.Exclamation)
            End If

            'Sort the list alphabetically
            BagelComboBox.Sorted = True

            .Focus()
        End With
    End Sub
    Private Sub SaveBagelListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveBagelListToolStripMenuItem.Click

        'Saves the bagel list in a file

        Dim NumberItemsInteger As Integer

        'Open the file
        Dim TypesStreamWriter As New StreamWriter("BagelType.txt", False)

        'Saves items in the file

        NumberItemsInteger = BagelComboBox.Items.Count - 1
        For IndexInteger As Integer = 0 To NumberItemsInteger
            TypesStreamWriter.WriteLine(BagelComboBox.Items(IndexInteger))

        Next IndexInteger
        TypesStreamWriter.Close()
        IsDirtyBoolean = False


    End Sub


    Private Sub RemoveBagelTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveBagelTypeToolStripMenuItem.Click
        'Remove the selected Bagel tpe from the list

        With BagelComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select the Bagel you want to remove from the list", "No selection made", MessageBoxButtons.OK, _
                MessageBoxIcon.Exclamation)
            End If
        End With

        'Sort the list alphabetically
        BagelComboBox.Sorted = True
    End Sub

    Private Sub ClearBagelListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearBagelListToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Do you want to clear the entire Bagel list?", "Clear Bagel list", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ResponseDialogResult = DialogResult.Yes Then
            BagelComboBox.Items.Clear()

        End If

    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayToolStripMenuItem.Click
        'Display a count of the different Bagels in the list
        Dim MessageString As String
        MessageString = "The differnt number of Bagels on the list is " & _
        BagelComboBox.Items.Count & "."
        MessageBox.Show(MessageString, "Bradley's Bagels Type Count", _
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox.ShowDialog()

    End Sub


    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Ask the user to save the file

        Dim ResponseDialogResult As DialogResult
        Dim MessageString As String = "Bagel list has changed. Save the list?"

        If IsDirtyBoolean Then
            ResponseDialogResult = MessageBox.Show(MessageString, "Bagel List Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ResponseDialogResult = DialogResult.Yes Then
                SaveBagelListToolStripMenuItem_Click(sender, e)
            End If
        End If



    End Sub



    Private Sub PrintDocument_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        'Declarations
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHightSingle As Single = PrintFont.GetHeight + 2 'Add two pixels for spacing.
        Dim HorizontalPrintLocationSingle As Single
        Dim VerticalPrintLocationSingle As Single
        Dim PrintLineString As String = "This is a Test Line to Print"

        HorizontalPrintLocationSingle = e.MarginBounds.Left
        VerticalPrintLocationSingle = e.MarginBounds.Top

        If BagelComboBox.Items.Count = 0 Then
            MsgBox("Please create a Bagel List")

        Else
            Using centerFormat As New StringFormat(StringFormatFlags.NoClip)
                With (centerFormat)
                    .Alignment = StringAlignment.Center
                    ' .LineAlignment = StringAlignment.Near
                End With

                Using headerFont As New Font("Times New Roman", 20, FontStyle.Bold Or FontStyle.Underline)
                    Dim headerString As String = "Bagel Type List"
                    e.Graphics.DrawString(headerString, headerFont, Brushes.Black, e.MarginBounds, centerFormat)
                End Using
            End Using


            'Print out all the items in he BagelComboBox list
            For ListIndexInteger As Integer = 0 To BagelComboBox.Items.Count - 1

                'Set up a line
                PrintLineString = BagelComboBox.Items(ListIndexInteger).ToString()

                'Send the line to the graphics page object
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

                'Increment the Y position for the next line
                VerticalPrintLocationSingle += LineHightSingle

            Next ListIndexInteger
        End If


    End Sub


    Private Sub PrintBagelListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintBagelListToolStripMenuItem.Click
        PrintPreviewDialog.Document = PrintDocument
        PrintPreviewDialog.ShowDialog()
    End Sub

End Class
