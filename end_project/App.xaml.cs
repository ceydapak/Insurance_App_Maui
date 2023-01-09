﻿namespace end_project;

public partial class App : Application
{
    public static DBTrans DBTrans { get; private set; }
    public App(DBTrans dbtrans)
	{
		InitializeComponent();

		MainPage = new AppShell();
        DBTrans = dbtrans;

    }
}
