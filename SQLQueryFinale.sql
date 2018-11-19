SET IDENTITY_INSERT [dbo].[Utilisateurs] ON
INSERT INTO [dbo].[Utilisateurs] ([UserID], [Nom], [Prenom]) VALUES (8, N'Ahmed', N'Abas')
INSERT INTO [dbo].[Utilisateurs] ([UserID], [Nom], [Prenom]) VALUES (9, N'Zakaria', N'Rizk')
INSERT INTO [dbo].[Utilisateurs] ([UserID], [Nom], [Prenom]) VALUES (10, N'Nabil', N'Fassi')
INSERT INTO [dbo].[Utilisateurs] ([UserID], [Nom], [Prenom]) VALUES (11, N'Othman', N'Taz')
SET IDENTITY_INSERT [dbo].[Utilisateurs] OFF

INSERT INTO [dbo].[SignUps] ([Email], [PassWord], [UserID], [ConfirmPassWord]) VALUES (N'ahmed@gmail.com', N'123', 8, N'123')
INSERT INTO [dbo].[SignUps] ([Email], [PassWord], [UserID], [ConfirmPassWord]) VALUES (N'Zakaria@gmail.com', N'123', 9, N'123')
INSERT INTO [dbo].[SignUps] ([Email], [PassWord], [UserID], [ConfirmPassWord]) VALUES (N'Nabil@gmail.com', N'123', 10, N'123')
INSERT INTO [dbo].[SignUps] ([Email], [PassWord], [UserID], [ConfirmPassWord]) VALUES (N'Othman@gmail.com', N'123', 11, N'123')

SET IDENTITY_INSERT [dbo].[Commandes] ON
INSERT INTO [dbo].[Commandes] ([CommandeID], [DateCommande], [User_UserID]) VALUES (7, N'1905-06-13 00:00:00', 8)
INSERT INTO [dbo].[Commandes] ([CommandeID], [DateCommande], [User_UserID]) VALUES (8, N'1905-06-13 00:00:00', 9)
INSERT INTO [dbo].[Commandes] ([CommandeID], [DateCommande], [User_UserID]) VALUES (9, N'1905-06-13 00:00:00', 10)
INSERT INTO [dbo].[Commandes] ([CommandeID], [DateCommande], [User_UserID]) VALUES (10, N'1905-06-13 00:00:00', 11)
SET IDENTITY_INSERT [dbo].[Commandes] OFF

SET IDENTITY_INSERT [dbo].[Produits] ON
INSERT INTO [dbo].[Produits] ([ProductID], [Nom], [Prix], [Com_CommandeID]) VALUES (3, N'Mieli', 100, 7)
INSERT INTO [dbo].[Produits] ([ProductID], [Nom], [Prix], [Com_CommandeID]) VALUES (4, N'Mielo', 100, 8)
INSERT INTO [dbo].[Produits] ([ProductID], [Nom], [Prix], [Com_CommandeID]) VALUES (5, N'Miles_fleurs', 80, 9)
INSERT INTO [dbo].[Produits] ([ProductID], [Nom], [Prix], [Com_CommandeID]) VALUES (6, N'Polen', 150, 10)
SET IDENTITY_INSERT [dbo].[Produits] OFF
