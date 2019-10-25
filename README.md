# Simple Entrance Examination System
Simple Entrance Examination System using C# winform and SQL Server

I include the database files(Database Files.zip). 1 with sample data and 1 without sample data.
Please attach it to your SQL Server before using there program.
'Set as StartUp project PresentationLayer' if you want to use the modules for Administrators/Clerk.
'Set as StartUp project PresentationLayer.Client' if you want to use the modules for Examinee.

**Login users from database with sample data:**
<br/>Username: arm001

Password: admin001


User Level: Administrator


Username: bityo002


Password: bityo002


User Level: Clerk

**Modules For Administrator/Clerk**
* LogIn - Administrator/Clerk must enter username and password to be able to use the program.
* Examinee - You can add/edit/delete users here.
* Exam Code - You can generate/print exam codes for examinees here.
* Create Exam - You can create examination, send examination to archive here.
* Subject - You can add/edit/delete subjects here.
* Report - You can print exam result, examinee info here.
* Settings - You can set passing rate(ex. 50 %), set days to wait if an examinee got exam code, restore examination.
* Change Password - You can change your password here.

**Modules For Examinee**
* Register - Examinee can register here by fillin up the needed info.
* StartExam - The examinee must enter the right exam code to take an exam.
* Exam - This is the module where examinee can read and answer the exam.
