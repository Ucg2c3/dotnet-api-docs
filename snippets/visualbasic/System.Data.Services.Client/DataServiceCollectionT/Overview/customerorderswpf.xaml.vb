﻿'<snippetWpfDataBinding> 
Imports System.Data.Services.Client
Imports System.Windows
Imports northwindclientvb.Northwind

Partial Public Class CustomerOrdersWpf
    Inherits Window

    Private context As NorthwindEntities
    Private trackedCustomers As DataServiceCollection(Of Customer)
    Private Const customerCountry As String = "Germany"
    Private Const svcUri As String = "http://localhost:12345/Northwind.svc/"
    Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Try
            ' Initialize the context for the data service.
            context = New NorthwindEntities(New Uri(svcUri))

            '<snippetMasterDetailBinding>
            ' Create a LINQ query that returns customers with related orders.
            Dim customerQuery = From cust In context.Customers.Expand("Orders")
                                Where cust.Country = customerCountry
                                Select cust

            ' Create a new collection for binding based on the LINQ query.
            trackedCustomers = New DataServiceCollection(Of Customer)(customerQuery)

            ' Bind the root StackPanel element to the collection
            ' related object binding paths are defined in the XAML.
            Me.LayoutRoot.DataContext = trackedCustomers
            '</snippetMasterDetailBinding>
        Catch ex As DataServiceQueryException
            MessageBox.Show("The query could not be completed:\n" + ex.ToString())
        Catch ex As InvalidOperationException
            MessageBox.Show("The following error occurred:\n" + ex.ToString())
        End Try
    End Sub
    Private Sub saveChangesButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Save changes to the data service.
        context.SaveChanges()
    End Sub
End Class
'</snippetWpfDataBinding>
