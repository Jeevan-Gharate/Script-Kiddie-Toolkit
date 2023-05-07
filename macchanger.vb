Imports System.Net.NetworkInformation

Public Class macchanger

    Function change_mac_address(ByVal adapter_transport_name As String, ByVal new_mac_address As String) As Integer
        ' use reg QUERY command to get available adapters from the registry
        Dim network_interface_reg_path As String = "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}"
        Dim output As String = Shell("cmd /c reg QUERY " & Replace(network_interface_reg_path, "\\", "\"), vbHide)
        output = output & vbNewLine ' append newline character to the end of the output
        Dim adapter_index As Integer = -1 ' initialize adapter index to -1

        ' search for the adapter with the specified transport name
        Dim reg_pattern As String = network_interface_reg_path & "\\[0-9]+"
        Dim reg_matches As Object = GetRegMatches(reg_pattern, output)
        For Each reg_match As Object In reg_matches
            Dim interface_content As String = Shell("cmd /c reg QUERY " & Replace(reg_match.Value, "\\", "\"), vbHide)
            If InStr(interface_content, adapter_transport_name) > 0 Then
                ' if the transport name of the adapter is found on the output of the reg QUERY command
                ' then this is the adapter we're looking for
                ' change the MAC address using reg ADD command
                Dim changing_mac_output As String = Shell("cmd /c reg add " & Replace(reg_match.Value, "\\", "\") & " /v NetworkAddress /d " & new_mac_address & " /f", vbHide)
                ' print the command output
                Debug.Print(changing_mac_output)
                ' set the adapter index to the index of the changed adapter's MAC address
                adapter_index = CInt(Split(reg_match.Value, "\")(UBound(Split(reg_match.Value, "\"))))
                ' exit the loop as we're done
                Exit For
            End If
        Next reg_match

        ' return the index of the changed adapter's MAC address
        change_mac_address = adapter_index
    End Function

    Function GetRegMatches(ByVal Pattern As String, ByVal InputString As String) As Object
        Dim objRegExp As Object
        Dim objMatches As Object
        objRegExp = CreateObject("VBScript.RegExp")
        objRegExp.Pattern = Pattern
        objRegExp.IgnoreCase = True
        objRegExp.Global = True
        objMatches = objRegExp.Execute(InputString)
        GetRegMatches = objMatches
    End Function


    Private Sub macchanger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nic As NetworkInterface = Nothing
        For Each ni As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
            If ni.OperationalStatus = OperationalStatus.Up Then
                If ni.NetworkInterfaceType = NetworkInterfaceType.Ethernet Or ni.NetworkInterfaceType = NetworkInterfaceType.Wireless80211 Then
                    If Not ni.Description.Contains("VirtualBox") Then
                        nic = ni
                        Exit For
                    End If
                End If
            End If
        Next

        If nic IsNot Nothing Then
            'MessageBox.Show("MAC address: " & nic.GetPhysicalAddress().ToString())
            Form2.original_mac = nic.GetPhysicalAddress().ToString()
        Else
            MessageBox.Show("No active Ethernet or WLAN adapter found.")
        End If

        Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()

        ' Add each interface to the dropdown menu
        For Each netInterface As NetworkInterface In interfaces
            ComboBox1.Items.Add(netInterface.Name)
        Next

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' all
        'Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        'For Each adapter As NetworkInterface In nics
        'If (adapter.OperationalStatus = OperationalStatus.Up) Then
        'Dim macAddress As PhysicalAddress = adapter.GetPhysicalAddress()
        '
        ' Display the MAC address
        'MessageBox.Show(macAddress.ToString())
        'End If
        'Next

        ' first one
        'Dim activeMacAddress As String = String.Empty
        'Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        'For Each adapter As NetworkInterface In nics
        'If (adapter.OperationalStatus = OperationalStatus.Up) AndAlso
        '   (adapter.NetworkInterfaceType = NetworkInterfaceType.Ethernet Or adapter.NetworkInterfaceType = NetworkInterfaceType.Wireless80211) Then
        'activeMacAddress = adapter.GetPhysicalAddress().ToString()
        'Exit For
        'End If
        'Next
        'MessageBox.Show(activeMacAddress)



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim adapterName As String = ComboBox1.SelectedItem ' Replace with the desired adapter name
        Dim networkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        For Each networkInterface As NetworkInterface In networkInterfaces
            If networkInterface.Name = adapterName Then
                Dim macAddress As String = BitConverter.ToString(networkInterface.GetPhysicalAddress().GetAddressBytes())
                'MessageBox.Show("MAC address of adapter " & adapterName & ": " & macAddress)
                Form2.original_mac = macAddress
                Exit For ' Exit the loop once the adapter is found
            End If
        Next

        If CheckBox2.Checked Then
            Dim randomMacAddress As PhysicalAddress
            Dim randomBytes(5) As Byte
            Dim rng As New System.Security.Cryptography.RNGCryptoServiceProvider()
            rng.GetBytes(randomBytes)
            randomBytes(0) = randomBytes(0) And 254 ' Ensure the first byte is odd, to avoid the broadcast and multicast address space
            randomMacAddress = New PhysicalAddress(randomBytes)
            MessageBox.Show(randomMacAddress.ToString())
            'MessageBox.Show("adapter: " & ComboBox1.SelectedItem)
            change_mac_address(ComboBox1.SelectedItem, randomMacAddress.ToString())

        Else
            change_mac_address(ComboBox1.SelectedItem, TextBox1.Text)

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class