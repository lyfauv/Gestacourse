﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Participant
{
	public virtual string Nom
	{
		get;
		set;
	}

	public virtual string Prénom
	{
		get;
		set;
	}

	public virtual int NbDossard
	{
		get;
		set;
	}

	public virtual int Age
	{
		get;
		set;
	}

	public virtual string Sexe
	{
		get;
		set;
	}

	public virtual string Courriel
	{
		get;
		set;
	}

	public virtual int NumLicenceFFA
	{
		get;
		set;
	}

	public virtual void AjouterSponsors()
	{
		throw new System.NotImplementedException();
	}

	public Participant()
	{
	}

	public Participant(string nom, string prenom, string courriel, int age, int ffa, string sexe)
	{
	}

}
