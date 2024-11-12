Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'My.Computer.Audio.Play("C:\Users\GHOST Fizer-48P4372\Documents\TheMastermind\.music\Naruto.WAV", AudioPlayMode.BackgroundLoop)
		Me.Activate()
		Call Melangeur()
		'Call comparerimage(ZPanel10.BackgroundImage)
	End Sub

	Public TourDeBoule As Integer = 1
	Public SiRouge As Boolean = False
	Public PetitRouge As Image = Global.TheMastermind.My.Resources.rouge_petit
	Public PetitBlanc As Image = Global.TheMastermind.My.Resources.blanc_petit
	Public Rouge As Image = Global.TheMastermind.My.Resources.red
	Public Jaune As Image = Global.TheMastermind.My.Resources.jaune
	Public Indigo As Image = Global.TheMastermind.My.Resources.indigo
	Public Orange As Image = Global.TheMastermind.My.Resources.orange
	Public Rose As Image = Global.TheMastermind.My.Resources.rose
	Public Vert As Image = Global.TheMastermind.My.Resources.green
	Public Clair As Image = Global.TheMastermind.My.Resources.clair
	Public Marron As Image = Global.TheMastermind.My.Resources.marron
	Public Violet As Image = Global.TheMastermind.My.Resources.violet
	Public Bleu As Image = Global.TheMastermind.My.Resources.bleu
	Public Gris As Image = Global.TheMastermind.My.Resources.gris
	Public Blanc As Image = Global.TheMastermind.My.Resources.blanc
	Public GrandNoir As Image = Global.TheMastermind.My.Resources.noir_vide3
	Public PetitNoir As Image = Global.TheMastermind.My.Resources.noir_vide_petit
	Public TableauImageBoule As New List(Of Image)({Rouge, Jaune, Indigo, Orange, Rose, Vert, Clair, Marron, Violet, Bleu, Gris, Blanc})
	Public CombinaisonMystere As New List(Of Image)()
	Public Generateur As New Random()
	Public CompteurDeTour As Integer = 0
	Public IndicateurAleatoire As Integer

	Public Function comparerimage(Image1 As Image) As Integer
		Dim map1 As Bitmap = New Bitmap(Image1)
		Dim map2 As Bitmap = New Bitmap(Global.TheMastermind.My.Resources.Resources.rouge_petit)
		Dim r As Integer
		If map1.GetPixel(map1.Width / 2, map1.Height / 2) <> map2.GetPixel(map2.Width / 2, map2.Height / 2) Then
			r = 0
		Else
			r = 1
		End If
		Return r
	End Function

	Public Function ComparerDeuxImages(Image1 As Image, Image2 As Image) As Integer
		Dim map1 As Bitmap = New Bitmap(Image1)
		Dim map2 As Bitmap = New Bitmap(Image2)
		Dim r As Integer
		If map1.GetPixel(map1.Width / 2, map1.Height / 2) <> map2.GetPixel(map2.Width / 2, map2.Height / 2) Then
			r = 0
		Else
			r = 1
		End If
		Return r
	End Function

	Public Sub ValiderPalier1()
		If comparerimage(Me.ZPanel1.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel2.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel3.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel4.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel5.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel6.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel7.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier2()
		If comparerimage(Me.ZPanel8.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel9.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel10.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel11.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel12.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel13.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel14.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier3()
		If comparerimage(Me.ZPanel15.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel16.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel17.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel18.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel19.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel20.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel21.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier4()
		If comparerimage(Me.ZPanel22.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel23.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel24.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel25.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel26.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel27.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel28.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier5()
		If comparerimage(Me.ZPanel29.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel30.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel31.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel32.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel33.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel34.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel35.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier6()
		If comparerimage(Me.ZPanel36.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel37.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel38.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel39.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel40.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel41.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel42.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier7()
		If comparerimage(Me.ZPanel43.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel44.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel45.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel46.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel47.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel48.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel49.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier8()
		If comparerimage(Me.ZPanel50.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel51.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel52.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel53.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel54.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel55.BackgroundImage) = 1 _
			And comparerimage(Me.ZPanel56.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier9()
		If comparerimage(Me.ZPanel57.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel58.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel59.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel60.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel61.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel62.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel63.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub ValiderPalier10()
		If comparerimage(Me.ZPanel64.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel65.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel66.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel67.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel68.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel69.BackgroundImage) = 1 _
			AndAlso comparerimage(Me.ZPanel70.BackgroundImage) = 1 Then
			SiRouge = True
		Else
			SiRouge = False
		End If
	End Sub

	Public Sub Melangeur()
		'Générer le tableau de 7 couleurs avec les boules mélangées
		While CompteurDeTour < 7
			IndicateurAleatoire = Generateur.Next(0, 11)
			CombinaisonMystere.Add(TableauImageBoule(IndicateurAleatoire))
			CompteurDeTour += 1
		End While
		'CombinaisonMystere(0) = Blanc
		'CombinaisonMystere(1) = Rouge
		'CombinaisonMystere(2) = Rouge
		'CombinaisonMystere(3) = Rouge
		'CombinaisonMystere(4) = Rouge
		'CombinaisonMystere(5) = Rouge
		'CombinaisonMystere(6) = Rouge
	End Sub
	Public Function TesterCombinaison(Test As Image) As Integer
		Dim retour As Integer = 0
		If ComparerDeuxImages(Test, CombinaisonMystere(0)) = 1 Or ComparerDeuxImages(Test, CombinaisonMystere(1)) = 1 Or ComparerDeuxImages(Test, CombinaisonMystere(2)) = 1 Or ComparerDeuxImages(Test, CombinaisonMystere(3)) = 1 Or ComparerDeuxImages(Test, CombinaisonMystere(4)) = 1 Or ComparerDeuxImages(Test, CombinaisonMystere(5)) = 1 Or ComparerDeuxImages(Test, CombinaisonMystere(6)) = 1 Then
			retour = 1
		End If
		Return retour
	End Function

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Rouge.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				ValiderPalier1()
				TourDeBoule += 1
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Rouge
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B_Jaune.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Jaune
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles B_Indigo.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Indigo
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles B_Orange.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Orange
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles B_Rose.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Rose
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles B_Vert.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Vert
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles B_Clair.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Clair
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles B_Marron.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Marron
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles B_Violet.Click

		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier1()
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Violet
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If
	End Sub

	Private Sub Recommencer_Click(sender As Object, e As EventArgs) Handles Recommencer.Click
		TourDeBoule = 1
		SiRouge = False
		Gagner.Text = ""
		Dim bool As Boolean = True
		If bool = True Then
			'resultat a zéro
			CPanel1.BackgroundImage = GrandNoir
			CPanel2.BackgroundImage = GrandNoir
			CPanel3.BackgroundImage = GrandNoir
			CPanel4.BackgroundImage = GrandNoir
			CPanel5.BackgroundImage = GrandNoir
			CPanel6.BackgroundImage = GrandNoir
			CPanel7.BackgroundImage = GrandNoir
			'grande boule a zéro
			GPanel1.BackgroundImage = GrandNoir
			GPanel2.BackgroundImage = GrandNoir
			GPanel3.BackgroundImage = GrandNoir
			GPanel4.BackgroundImage = GrandNoir
			GPanel5.BackgroundImage = GrandNoir
			GPanel6.BackgroundImage = GrandNoir
			GPanel7.BackgroundImage = GrandNoir
			GPanel8.BackgroundImage = GrandNoir
			GPanel9.BackgroundImage = GrandNoir
			GPanel10.BackgroundImage = GrandNoir
			GPanel11.BackgroundImage = GrandNoir
			GPanel12.BackgroundImage = GrandNoir
			GPanel13.BackgroundImage = GrandNoir
			GPanel14.BackgroundImage = GrandNoir
			GPanel15.BackgroundImage = GrandNoir
			GPanel16.BackgroundImage = GrandNoir
			GPanel17.BackgroundImage = GrandNoir
			GPanel18.BackgroundImage = GrandNoir
			GPanel19.BackgroundImage = GrandNoir
			GPanel20.BackgroundImage = GrandNoir
			GPanel21.BackgroundImage = GrandNoir
			GPanel22.BackgroundImage = GrandNoir
			GPanel23.BackgroundImage = GrandNoir
			GPanel24.BackgroundImage = GrandNoir
			GPanel25.BackgroundImage = GrandNoir
			GPanel26.BackgroundImage = GrandNoir
			GPanel27.BackgroundImage = GrandNoir
			GPanel28.BackgroundImage = GrandNoir
			GPanel29.BackgroundImage = GrandNoir
			GPanel30.BackgroundImage = GrandNoir
			GPanel31.BackgroundImage = GrandNoir
			GPanel32.BackgroundImage = GrandNoir
			GPanel33.BackgroundImage = GrandNoir
			GPanel34.BackgroundImage = GrandNoir
			GPanel35.BackgroundImage = GrandNoir
			GPanel36.BackgroundImage = GrandNoir
			GPanel37.BackgroundImage = GrandNoir
			GPanel38.BackgroundImage = GrandNoir
			GPanel39.BackgroundImage = GrandNoir
			GPanel40.BackgroundImage = GrandNoir
			GPanel41.BackgroundImage = GrandNoir
			GPanel42.BackgroundImage = GrandNoir
			GPanel43.BackgroundImage = GrandNoir
			GPanel44.BackgroundImage = GrandNoir
			GPanel45.BackgroundImage = GrandNoir
			GPanel46.BackgroundImage = GrandNoir
			GPanel47.BackgroundImage = GrandNoir
			GPanel48.BackgroundImage = GrandNoir
			GPanel49.BackgroundImage = GrandNoir
			GPanel50.BackgroundImage = GrandNoir
			GPanel51.BackgroundImage = GrandNoir
			GPanel52.BackgroundImage = GrandNoir
			GPanel53.BackgroundImage = GrandNoir
			GPanel54.BackgroundImage = GrandNoir
			GPanel55.BackgroundImage = GrandNoir
			GPanel56.BackgroundImage = GrandNoir
			GPanel57.BackgroundImage = GrandNoir
			GPanel58.BackgroundImage = GrandNoir
			GPanel59.BackgroundImage = GrandNoir
			GPanel60.BackgroundImage = GrandNoir
			GPanel61.BackgroundImage = GrandNoir
			GPanel62.BackgroundImage = GrandNoir
			GPanel63.BackgroundImage = GrandNoir
			GPanel64.BackgroundImage = GrandNoir
			GPanel65.BackgroundImage = GrandNoir
			GPanel66.BackgroundImage = GrandNoir
			GPanel67.BackgroundImage = GrandNoir
			GPanel68.BackgroundImage = GrandNoir
			GPanel69.BackgroundImage = GrandNoir
			GPanel70.BackgroundImage = GrandNoir
			'petites boules a zéro
			ZPanel1.BackgroundImage = GrandNoir
			ZPanel2.BackgroundImage = GrandNoir
			ZPanel3.BackgroundImage = GrandNoir
			ZPanel4.BackgroundImage = GrandNoir
			ZPanel5.BackgroundImage = GrandNoir
			ZPanel6.BackgroundImage = GrandNoir
			ZPanel7.BackgroundImage = GrandNoir
			ZPanel8.BackgroundImage = GrandNoir
			ZPanel9.BackgroundImage = GrandNoir
			ZPanel10.BackgroundImage = GrandNoir
			ZPanel11.BackgroundImage = GrandNoir
			ZPanel12.BackgroundImage = GrandNoir
			ZPanel13.BackgroundImage = GrandNoir
			ZPanel14.BackgroundImage = GrandNoir
			ZPanel15.BackgroundImage = GrandNoir
			ZPanel16.BackgroundImage = GrandNoir
			ZPanel17.BackgroundImage = GrandNoir
			ZPanel18.BackgroundImage = GrandNoir
			ZPanel19.BackgroundImage = GrandNoir
			ZPanel20.BackgroundImage = GrandNoir
			ZPanel21.BackgroundImage = GrandNoir
			ZPanel22.BackgroundImage = GrandNoir
			ZPanel23.BackgroundImage = GrandNoir
			ZPanel24.BackgroundImage = GrandNoir
			ZPanel25.BackgroundImage = GrandNoir
			ZPanel26.BackgroundImage = GrandNoir
			ZPanel27.BackgroundImage = GrandNoir
			ZPanel28.BackgroundImage = GrandNoir
			ZPanel29.BackgroundImage = GrandNoir
			ZPanel30.BackgroundImage = GrandNoir
			ZPanel31.BackgroundImage = GrandNoir
			ZPanel32.BackgroundImage = GrandNoir
			ZPanel33.BackgroundImage = GrandNoir
			ZPanel34.BackgroundImage = GrandNoir
			ZPanel35.BackgroundImage = GrandNoir
			ZPanel36.BackgroundImage = GrandNoir
			ZPanel37.BackgroundImage = GrandNoir
			ZPanel38.BackgroundImage = GrandNoir
			ZPanel39.BackgroundImage = GrandNoir
			ZPanel40.BackgroundImage = GrandNoir
			ZPanel41.BackgroundImage = GrandNoir
			ZPanel42.BackgroundImage = GrandNoir
			ZPanel43.BackgroundImage = GrandNoir
			ZPanel44.BackgroundImage = GrandNoir
			ZPanel45.BackgroundImage = GrandNoir
			ZPanel46.BackgroundImage = GrandNoir
			ZPanel47.BackgroundImage = GrandNoir
			ZPanel48.BackgroundImage = PetitNoir
			ZPanel49.BackgroundImage = PetitNoir
			ZPanel50.BackgroundImage = PetitNoir
			ZPanel51.BackgroundImage = PetitNoir
			ZPanel52.BackgroundImage = PetitNoir
			ZPanel53.BackgroundImage = PetitNoir
			ZPanel54.BackgroundImage = PetitNoir
			ZPanel55.BackgroundImage = PetitNoir
			ZPanel56.BackgroundImage = PetitNoir
			ZPanel57.BackgroundImage = PetitNoir
			ZPanel58.BackgroundImage = PetitNoir
			ZPanel59.BackgroundImage = PetitNoir
			ZPanel60.BackgroundImage = PetitNoir
			ZPanel61.BackgroundImage = PetitNoir
			ZPanel62.BackgroundImage = PetitNoir
			ZPanel63.BackgroundImage = PetitNoir
			ZPanel64.BackgroundImage = PetitNoir
			ZPanel65.BackgroundImage = PetitNoir
			ZPanel66.BackgroundImage = PetitNoir
			ZPanel67.BackgroundImage = PetitNoir
			ZPanel68.BackgroundImage = PetitNoir
			ZPanel69.BackgroundImage = PetitNoir
			ZPanel70.BackgroundImage = PetitNoir
			bool = False
		End If
	End Sub

	Private Sub MenuP_Click(sender As Object, e As EventArgs) Handles MenuP.Click
		Me.Hide()
		FenetreAcceuil.Show()
	End Sub

	Private Sub B_Blanc_Click(sender As Object, e As EventArgs) Handles B_Blanc.Click
		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				ValiderPalier1()
				TourDeBoule += 1
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Blanc
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If
	End Sub

	Private Sub B_Bleu_Click(sender As Object, e As EventArgs) Handles B_Bleu.Click
		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				ValiderPalier1()
				TourDeBoule += 1
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Bleu
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub

	Private Sub B_Gris_Click(sender As Object, e As EventArgs) Handles B_Gris.Click
		If TourDeBoule < 71 AndAlso SiRouge = False Then
			'Palier 1
			If TourDeBoule = 1 Then
				GPanel1.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) Then
					ZPanel1.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel1.BackgroundImage, CombinaisonMystere(0)) = 0 And TesterCombinaison(GPanel1.BackgroundImage) = 1 Then
					ZPanel1.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 2 Then
				GPanel2.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) Then
					ZPanel2.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel2.BackgroundImage, CombinaisonMystere(1)) = 0 And TesterCombinaison(GPanel2.BackgroundImage) = 1 Then
					ZPanel2.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 3 Then
				GPanel3.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) Then
					ZPanel3.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel3.BackgroundImage, CombinaisonMystere(2)) = 0 And TesterCombinaison(GPanel3.BackgroundImage) = 1 Then
					ZPanel3.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 4 Then
				GPanel4.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) Then
					ZPanel4.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel4.BackgroundImage, CombinaisonMystere(3)) = 0 And TesterCombinaison(GPanel4.BackgroundImage) = 1 Then
					ZPanel4.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 5 Then
				GPanel5.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) Then
					ZPanel5.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel5.BackgroundImage, CombinaisonMystere(4)) = 0 And TesterCombinaison(GPanel5.BackgroundImage) = 1 Then
					ZPanel5.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 6 Then
				GPanel6.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) Then
					ZPanel6.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel6.BackgroundImage, CombinaisonMystere(5)) = 0 And TesterCombinaison(GPanel6.BackgroundImage) = 1 Then
					ZPanel6.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 7 Then
				GPanel7.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) Then
					ZPanel7.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel7.BackgroundImage, CombinaisonMystere(6)) = 0 And TesterCombinaison(GPanel7.BackgroundImage) = 1 Then
					ZPanel7.BackgroundImage = PetitBlanc
				Else

				End If
				ValiderPalier1()
				TourDeBoule += 1
				'Palier 2
			ElseIf TourDeBoule = 8 Then
				GPanel8.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) Then
					ZPanel8.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel8.BackgroundImage, CombinaisonMystere(7 - 7)) = 0 And TesterCombinaison(GPanel8.BackgroundImage) = 1 Then
					ZPanel8.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 9 Then
				GPanel9.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) Then
					ZPanel9.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel9.BackgroundImage, CombinaisonMystere(8 - 7)) = 0 And TesterCombinaison(GPanel9.BackgroundImage) = 1 Then
					ZPanel9.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 10 Then
				GPanel10.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) Then
					ZPanel10.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel10.BackgroundImage, CombinaisonMystere(9 - 7)) = 0 And TesterCombinaison(GPanel10.BackgroundImage) = 1 Then
					ZPanel10.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 11 Then
				GPanel11.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) Then
					ZPanel11.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel11.BackgroundImage, CombinaisonMystere(10 - 7)) = 0 And TesterCombinaison(GPanel11.BackgroundImage) = 1 Then
					ZPanel11.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 12 Then
				GPanel12.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) Then
					ZPanel12.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel12.BackgroundImage, CombinaisonMystere(11 - 7)) = 0 And TesterCombinaison(GPanel12.BackgroundImage) = 1 Then
					ZPanel12.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 13 Then
				GPanel13.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) Then
					ZPanel13.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel13.BackgroundImage, CombinaisonMystere(12 - 7)) = 0 And TesterCombinaison(GPanel13.BackgroundImage) = 1 Then
					ZPanel13.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 14 Then
				GPanel14.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) Then
					ZPanel14.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel14.BackgroundImage, CombinaisonMystere(13 - 7)) = 0 And TesterCombinaison(GPanel14.BackgroundImage) = 1 Then
					ZPanel14.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier2()
				'Palier 3
			ElseIf TourDeBoule = 15 Then
				GPanel15.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) Then
					ZPanel15.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel15.BackgroundImage, CombinaisonMystere(14 - 14)) = 0 And TesterCombinaison(GPanel15.BackgroundImage) = 1 Then
					ZPanel15.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 16 Then
				GPanel16.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) Then
					ZPanel16.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel16.BackgroundImage, CombinaisonMystere(15 - 14)) = 0 And TesterCombinaison(GPanel16.BackgroundImage) = 1 Then
					ZPanel16.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 17 Then
				GPanel17.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) Then
					ZPanel17.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel17.BackgroundImage, CombinaisonMystere(16 - 14)) = 0 And TesterCombinaison(GPanel17.BackgroundImage) = 1 Then
					ZPanel17.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 18 Then
				GPanel18.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) Then
					ZPanel18.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel18.BackgroundImage, CombinaisonMystere(17 - 14)) = 0 And TesterCombinaison(GPanel18.BackgroundImage) = 1 Then
					ZPanel18.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 19 Then
				GPanel19.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) Then
					ZPanel19.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel19.BackgroundImage, CombinaisonMystere(18 - 14)) = 0 And TesterCombinaison(GPanel19.BackgroundImage) = 1 Then
					ZPanel19.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 20 Then
				GPanel20.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) Then
					ZPanel20.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel20.BackgroundImage, CombinaisonMystere(19 - 14)) = 0 And TesterCombinaison(GPanel20.BackgroundImage) = 1 Then
					ZPanel20.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 21 Then
				GPanel21.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) Then
					ZPanel21.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel21.BackgroundImage, CombinaisonMystere(20 - 14)) = 0 And TesterCombinaison(GPanel21.BackgroundImage) = 1 Then
					ZPanel21.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier3()
				'Palier 4
			ElseIf TourDeBoule = 22 Then
				GPanel22.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) Then
					ZPanel22.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel22.BackgroundImage, CombinaisonMystere(21 - 21)) = 0 And TesterCombinaison(GPanel22.BackgroundImage) = 1 Then
					ZPanel22.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 23 Then
				GPanel23.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) Then
					ZPanel23.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel23.BackgroundImage, CombinaisonMystere(22 - 21)) = 0 And TesterCombinaison(GPanel23.BackgroundImage) = 1 Then
					ZPanel23.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 24 Then
				GPanel24.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) Then
					ZPanel24.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel24.BackgroundImage, CombinaisonMystere(23 - 21)) = 0 And TesterCombinaison(GPanel24.BackgroundImage) = 1 Then
					ZPanel24.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 25 Then
				GPanel25.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) Then
					ZPanel25.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel25.BackgroundImage, CombinaisonMystere(24 - 21)) = 0 And TesterCombinaison(GPanel25.BackgroundImage) = 1 Then
					ZPanel25.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 26 Then
				GPanel26.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) Then
					ZPanel26.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel26.BackgroundImage, CombinaisonMystere(25 - 21)) = 0 And TesterCombinaison(GPanel26.BackgroundImage) = 1 Then
					ZPanel26.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 27 Then
				GPanel27.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) Then
					ZPanel27.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel27.BackgroundImage, CombinaisonMystere(26 - 21)) = 0 And TesterCombinaison(GPanel27.BackgroundImage) = 1 Then
					ZPanel27.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 28 Then
				GPanel28.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) Then
					ZPanel28.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel28.BackgroundImage, CombinaisonMystere(27 - 21)) = 0 And TesterCombinaison(GPanel28.BackgroundImage) = 1 Then
					ZPanel28.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier4()
				'Palier 5
			ElseIf TourDeBoule = 29 Then
				GPanel29.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) Then
					ZPanel29.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel29.BackgroundImage, CombinaisonMystere(28 - 28)) = 0 And TesterCombinaison(GPanel29.BackgroundImage) = 1 Then
					ZPanel29.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 30 Then
				GPanel30.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) Then
					ZPanel30.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel30.BackgroundImage, CombinaisonMystere(29 - 28)) = 0 And TesterCombinaison(GPanel30.BackgroundImage) = 1 Then
					ZPanel30.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 31 Then
				GPanel31.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) Then
					ZPanel31.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel31.BackgroundImage, CombinaisonMystere(30 - 28)) = 0 And TesterCombinaison(GPanel31.BackgroundImage) = 1 Then
					ZPanel31.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 32 Then
				GPanel32.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) Then
					ZPanel32.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel32.BackgroundImage, CombinaisonMystere(31 - 28)) = 0 And TesterCombinaison(GPanel32.BackgroundImage) = 1 Then
					ZPanel32.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 33 Then
				GPanel33.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) Then
					ZPanel33.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel33.BackgroundImage, CombinaisonMystere(32 - 28)) = 0 And TesterCombinaison(GPanel33.BackgroundImage) = 1 Then
					ZPanel33.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 34 Then
				GPanel34.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) Then
					ZPanel34.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel34.BackgroundImage, CombinaisonMystere(33 - 28)) = 0 And TesterCombinaison(GPanel34.BackgroundImage) = 1 Then
					ZPanel34.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 35 Then
				GPanel35.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) Then
					ZPanel35.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel35.BackgroundImage, CombinaisonMystere(34 - 28)) = 0 And TesterCombinaison(GPanel35.BackgroundImage) = 1 Then
					ZPanel35.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier5()
				'Palier 6
			ElseIf TourDeBoule = 36 Then
				GPanel36.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) Then
					ZPanel36.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel36.BackgroundImage, CombinaisonMystere(35 - 35)) = 0 And TesterCombinaison(GPanel36.BackgroundImage) = 1 Then
					ZPanel36.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 37 Then
				GPanel37.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) Then
					ZPanel37.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel37.BackgroundImage, CombinaisonMystere(36 - 35)) = 0 And TesterCombinaison(GPanel37.BackgroundImage) = 1 Then
					ZPanel37.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 38 Then
				GPanel38.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) Then
					ZPanel38.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel38.BackgroundImage, CombinaisonMystere(37 - 35)) = 0 And TesterCombinaison(GPanel38.BackgroundImage) = 1 Then
					ZPanel38.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 39 Then
				GPanel39.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) Then
					ZPanel39.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel39.BackgroundImage, CombinaisonMystere(38 - 35)) = 0 And TesterCombinaison(GPanel39.BackgroundImage) = 1 Then
					ZPanel39.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 40 Then
				GPanel40.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) Then
					ZPanel40.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel40.BackgroundImage, CombinaisonMystere(39 - 35)) = 0 And TesterCombinaison(GPanel40.BackgroundImage) = 1 Then
					ZPanel40.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 41 Then
				GPanel41.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) Then
					ZPanel41.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel41.BackgroundImage, CombinaisonMystere(40 - 35)) = 0 And TesterCombinaison(GPanel41.BackgroundImage) = 1 Then
					ZPanel41.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 42 Then
				GPanel42.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) Then
					ZPanel42.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel42.BackgroundImage, CombinaisonMystere(41 - 35)) = 0 And TesterCombinaison(GPanel42.BackgroundImage) = 1 Then
					ZPanel42.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier6()
				'Palier 7
			ElseIf TourDeBoule = 43 Then
				GPanel43.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) Then
					ZPanel43.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel43.BackgroundImage, CombinaisonMystere(42 - 42)) = 0 And TesterCombinaison(GPanel43.BackgroundImage) = 1 Then
					ZPanel43.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 44 Then
				GPanel44.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) Then
					ZPanel44.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel44.BackgroundImage, CombinaisonMystere(43 - 42)) = 0 And TesterCombinaison(GPanel44.BackgroundImage) = 1 Then
					ZPanel44.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 45 Then
				GPanel45.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) Then
					ZPanel45.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel45.BackgroundImage, CombinaisonMystere(44 - 42)) = 0 And TesterCombinaison(GPanel45.BackgroundImage) = 1 Then
					ZPanel45.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 46 Then
				GPanel46.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) Then
					ZPanel46.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel46.BackgroundImage, CombinaisonMystere(45 - 42)) = 0 And TesterCombinaison(GPanel46.BackgroundImage) = 1 Then
					ZPanel46.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 47 Then
				GPanel47.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) Then
					ZPanel47.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel47.BackgroundImage, CombinaisonMystere(46 - 42)) = 0 And TesterCombinaison(GPanel47.BackgroundImage) = 1 Then
					ZPanel47.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 48 Then
				GPanel48.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) Then
					ZPanel48.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel48.BackgroundImage, CombinaisonMystere(47 - 42)) = 0 And TesterCombinaison(GPanel48.BackgroundImage) = 1 Then
					ZPanel48.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 49 Then
				GPanel49.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) Then
					ZPanel49.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel49.BackgroundImage, CombinaisonMystere(48 - 42)) = 0 And TesterCombinaison(GPanel49.BackgroundImage) = 1 Then
					ZPanel49.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier7()
				'Palier 8
			ElseIf TourDeBoule = 50 Then
				GPanel50.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) Then
					ZPanel50.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel50.BackgroundImage, CombinaisonMystere(49 - 49)) = 0 And TesterCombinaison(GPanel50.BackgroundImage) = 1 Then
					ZPanel50.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 51 Then
				GPanel51.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) Then
					ZPanel51.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel51.BackgroundImage, CombinaisonMystere(50 - 49)) = 0 And TesterCombinaison(GPanel51.BackgroundImage) = 1 Then
					ZPanel51.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 52 Then
				GPanel52.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) Then
					ZPanel52.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel52.BackgroundImage, CombinaisonMystere(51 - 49)) = 0 And TesterCombinaison(GPanel52.BackgroundImage) = 1 Then
					ZPanel52.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 53 Then
				GPanel53.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) Then
					ZPanel53.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel53.BackgroundImage, CombinaisonMystere(52 - 49)) = 0 And TesterCombinaison(GPanel53.BackgroundImage) = 1 Then
					ZPanel53.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 54 Then
				GPanel54.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) Then
					ZPanel54.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel54.BackgroundImage, CombinaisonMystere(53 - 49)) = 0 And TesterCombinaison(GPanel54.BackgroundImage) = 1 Then
					ZPanel54.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 55 Then
				GPanel55.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) Then
					ZPanel55.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel55.BackgroundImage, CombinaisonMystere(54 - 49)) = 0 And TesterCombinaison(GPanel55.BackgroundImage) = 1 Then
					ZPanel55.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 56 Then
				GPanel56.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) Then
					ZPanel56.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel56.BackgroundImage, CombinaisonMystere(55 - 49)) = 0 And TesterCombinaison(GPanel56.BackgroundImage) = 1 Then
					ZPanel56.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier8()
				'Palier 9
			ElseIf TourDeBoule = 57 Then
				GPanel57.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) Then
					ZPanel57.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel57.BackgroundImage, CombinaisonMystere(56 - 56)) = 0 And TesterCombinaison(GPanel57.BackgroundImage) = 1 Then
					ZPanel57.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 58 Then
				GPanel58.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) Then
					ZPanel58.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel58.BackgroundImage, CombinaisonMystere(57 - 56)) = 0 And TesterCombinaison(GPanel58.BackgroundImage) = 1 Then
					ZPanel58.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 59 Then
				GPanel59.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) Then
					ZPanel59.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel59.BackgroundImage, CombinaisonMystere(58 - 56)) = 0 And TesterCombinaison(GPanel59.BackgroundImage) = 1 Then
					ZPanel59.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 60 Then
				GPanel60.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) Then
					ZPanel60.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel60.BackgroundImage, CombinaisonMystere(59 - 56)) = 0 And TesterCombinaison(GPanel60.BackgroundImage) = 1 Then
					ZPanel60.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 61 Then
				GPanel61.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) Then
					ZPanel61.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel61.BackgroundImage, CombinaisonMystere(60 - 56)) = 0 And TesterCombinaison(GPanel61.BackgroundImage) = 1 Then
					ZPanel61.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 62 Then
				GPanel62.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) Then
					ZPanel62.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel62.BackgroundImage, CombinaisonMystere(61 - 56)) = 0 And TesterCombinaison(GPanel62.BackgroundImage) = 1 Then
					ZPanel62.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 63 Then
				GPanel63.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) Then
					ZPanel63.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel63.BackgroundImage, CombinaisonMystere(62 - 56)) = 0 And TesterCombinaison(GPanel63.BackgroundImage) = 1 Then
					ZPanel63.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier9()
				'Palier 10
			ElseIf TourDeBoule = 64 Then
				GPanel64.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) Then
					ZPanel64.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel64.BackgroundImage, CombinaisonMystere(63 - 63)) = 0 And TesterCombinaison(GPanel64.BackgroundImage) = 1 Then
					ZPanel64.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 65 Then
				GPanel65.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) Then
					ZPanel65.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel65.BackgroundImage, CombinaisonMystere(64 - 63)) = 0 And TesterCombinaison(GPanel65.BackgroundImage) = 1 Then
					ZPanel65.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 66 Then
				GPanel66.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) Then
					ZPanel66.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel66.BackgroundImage, CombinaisonMystere(65 - 63)) = 0 And TesterCombinaison(GPanel66.BackgroundImage) = 1 Then
					ZPanel66.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 67 Then
				GPanel67.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) Then
					ZPanel67.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel67.BackgroundImage, CombinaisonMystere(66 - 63)) = 0 And TesterCombinaison(GPanel67.BackgroundImage) = 1 Then
					ZPanel67.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 68 Then
				GPanel68.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) Then
					ZPanel68.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel68.BackgroundImage, CombinaisonMystere(67 - 63)) = 0 And TesterCombinaison(GPanel68.BackgroundImage) = 1 Then
					ZPanel68.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 69 Then
				GPanel69.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) Then
					ZPanel69.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel69.BackgroundImage, CombinaisonMystere(68 - 63)) = 0 And TesterCombinaison(GPanel69.BackgroundImage) = 1 Then
					ZPanel69.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
			ElseIf TourDeBoule = 70 Then
				GPanel70.BackgroundImage = Gris
				If ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) Then
					ZPanel70.BackgroundImage = PetitRouge
				ElseIf ComparerDeuxImages(GPanel70.BackgroundImage, CombinaisonMystere(69 - 63)) = 0 And TesterCombinaison(GPanel70.BackgroundImage) = 1 Then
					ZPanel70.BackgroundImage = PetitBlanc
				Else

				End If
				TourDeBoule += 1
				ValiderPalier10()
			End If
		ElseIf SiRouge = False Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS PERDU !"
		ElseIf SiRouge = True Then
			CPanel1.BackgroundImage = CombinaisonMystere(0)
			CPanel2.BackgroundImage = CombinaisonMystere(1)
			CPanel3.BackgroundImage = CombinaisonMystere(2)
			CPanel4.BackgroundImage = CombinaisonMystere(3)
			CPanel5.BackgroundImage = CombinaisonMystere(4)
			CPanel6.BackgroundImage = CombinaisonMystere(5)
			CPanel7.BackgroundImage = CombinaisonMystere(6)
			Gagner.Text = "TU AS GAGNE !"
		End If

	End Sub
End Class