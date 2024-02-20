Public Class Form1
    dim obj as New DataBaseAccess
    Dim dt As DataTable
    Dim sc As String = obj.ConnectionString()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                ListBox1.Items.Add(DataGridView1.Rows(i).Cells(1).Value.ToString())


            next
        Catch ex As Exception

        End Try


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim sql as String = "SET IDENTITY_INSERT [dbo].[Clientes] ON 
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (1, N'Alfreds Futterkiste')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (2, N'Ana Trujillo Emparedados y helados')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (3, N'Antonio Moreno Taquería')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (4, N'Around the Horn')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (5, N'Berglunds snabbköp')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (6, N'Blauer See Delikatessen')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (7, N'Blondel père et fils')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (8, N'Bólido Comidas preparadas')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (9, N'Bon app''')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (10, N'Bottom-Dollar Markets')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (11, N'B''s Beverages')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (12, N'Cactus Comidas para llevar')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (13, N'Centro comercial Moctezuma')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (14, N'Chop-suey Chinese')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (15, N'Comércio Mineiro')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (16, N'Consolidated Holdings')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (17, N'Drachenblut Delikatessen')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (18, N'Du monde entier')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (19, N'Eastern Connection')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (20, N'Ernst Handel')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (21, N'Familia Arquibaldo')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (22, N'FISSA Fabrica Inter. Salchichas S.A.')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (23, N'Folies gourmandes')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (24, N'Folk och fä HB')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (25, N'Frankenversand')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (26, N'France restauration')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (27, N'Franchi S.p.A.')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (28, N'Furia Bacalhau e Frutos do Mar')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (29, N'Galería del gastrónomo')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (30, N'Godos Cocina Típica')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (31, N'Gourmet Lanchonetes')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (32, N'Great Lakes Food Market')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (33, N'GROSELLA-Restaurante')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (34, N'Hanari Carnes')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (35, N'HILARIÓN-Abastos')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (36, N'Hungry Coyote Import Store')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (37, N'Hungry Owl All-Night Grocers')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (38, N'Island Trading')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (39, N'Königlich Essen')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (40, N'La corne d''abondance')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (41, N'La maison d''Asie')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (42, N'Laughing Bacchus Wine Cellars')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (43, N'Lazy K Kountry Store')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (44, N'Lehmanns Marktstand')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (45, N'Let''s Stop N Shop')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (46, N'LILA-Supermercado')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (47, N'LINO-Delicateses')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (48, N'Lonesome Pine Restaurant')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (49, N'Magazzini Alimentari Riuniti')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (50, N'Maison Dewey')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (51, N'Mère Paillarde')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (52, N'Morgenstern Gesundkost')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (53, N'North/South')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (54, N'Océano Atlántico Ltda.')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (55, N'Old World Delicatessen')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (56, N'Ottilies Käseladen')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (57, N'Paris spécialités')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (58, N'Pericles Comidas clásicas')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (59, N'Piccolo und mehr')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (60, N'Princesa Isabel Vinhos')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (61, N'Que Delícia')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (62, N'Queen Cozinha')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (63, N'QUICK-Stop')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (64, N'Rancho grande')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (65, N'Rattlesnake Canyon Grocery')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (66, N'Reggiani Caseifici')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (67, N'Ricardo Adocicados')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (68, N'Richter Supermarkt')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (69, N'Romero y tomillo')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (70, N'Santé Gourmet')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (71, N'Save-a-lot Markets')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (72, N'Seven Seas Imports')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (73, N'Simons bistro')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (74, N'Spécialités du monde')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (75, N'Split Rail Beer & Ale')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (76, N'Suprêmes délices')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (77, N'The Big Cheese')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (78, N'The Cracker Box')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (79, N'Toms Spezialitäten')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (80, N'Tortuga Restaurante')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (81, N'Tradição Hipermercados')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (82, N'Trail''s Head Gourmet Provisioners')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (83, N'Vaffeljernet')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (84, N'Victuailles en stock')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (85, N'Vins et alcools Chevalier')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (86, N'Die Wandernde Kuh')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (87, N'Wartian Herkku')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (88, N'Wellington Importadora')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (89, N'White Clover Markets')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (90, N'Wilman Kala')
INSERT [dbo].[Clientes] ([id], [nome_empresa]) VALUES (91, N'Wolski  Zajazd')
"
            dt = obj.BuscarDados(sc, sql)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        try

            Dim sql As String = "delete from Clientes
        dbcc checkident(clientes, reseed, 0)"
            dt = obj.BuscarDados(sc, sql)
        Catch ex As Exception
            MessageBox.Show("Conflito entre Chaves Primarias e Chaves Estrangeiras")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String = "SELECT * FROM Clientes"
        dt = obj.BuscarDados(sc, sql)
        DataGridView1.DataSource = dt
    End Sub
End Class
