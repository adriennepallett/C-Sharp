**********************************************************************************************
FINAL PROJECT: WEB SERVICES AND SYSTEMS CSIS4311
AUTHOR: ADRIENNE PALLETT
VERSION: 1.1
INITIAL RELEASE: April 24, 2024
PURPOSE: The purpose of this program is to allow a user to track their various classes towards their degree. 
**********************************************************************************************

System Architecture:
	FRONT-END: Views using C#HTML and CSS using Microsoft Visual Studio Community
	BACK-END: Created to ensure functionality using C# JS
	WEB APP DATA: I was unable to use MySQLServer, or MongoDB (Mac OSX Versioning Issue) 		so the data has been hardcoded in Services > DataSet.cs
	WEB SERVICE: User Authentication in C# and C#HTML


Instructions:
	1. Download the zip file (if using GitHub)
	2. You can play around using my DataSet.cs or you will need to create your own. See 		below for blank data set to fill in the blanks with your own data, if you wish 		to do so. 
	3. Once the program is opened in a web browser of your choice, there are 3 pre- 		programmed user logins. See USER LOGIN section below. 
	4. Log in and play around. Let me know what you find or think!


Bug Reporting:
	There are currently two "bugs" in this program that I have been unable to figure out. 

	BUG0001: There is an issue when editing a record multiple times. If you create a new 		record, and you edit the Degree Section of the program more than once. 			Example: Major > Minor > Gen Ed, the record will remain in the second (Minor) 		section	and will be duplicated in the third section (Gen Ed)
	
			Affected Files: Controllers > ClassController.cs
					Services > ClassDAO.cs
	
	BUG0002: Because I am not able to successfully link a database with the course records 		to help maintain state, Any information entered within this system will 		maintain only while the window is active.

			Affected Files: Controllers > ClassController.cs
					Services > DataSet.cs


BLANK DATASET.CS IS FOUND IN ProjectFinal > ProjectFinal > Services > BlankDataSet.cs
	
	Note: Be sure to relink the data set within the program to the dataset you create. 
	

Sample User Logins:
	* These are case sensitive *
	
	Username: Tester
	Password: Test1234