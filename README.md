                                                                                                                                                                        
קופת חולים-Maccabi4u
תיאור הפרויקט:
מערכת לניהול תורים לקופת חולים  באמצעות המערכת ניתן להזמין תור לרופא 
ולנהל את כלל התורים בתחנה.
ישויות:
פציינט
רופא
תור
מיפוי Routs לפציינט:
שליפת רשימת פציינטים	GET:https //maccabi4u.co.il/patients
שליפת פציינט לפי מזהה	GET:https //maccabi4u.co.il/patients/1
הוספת פציינט	POS: https // maccabi4u.co.il/patients
עדכון פציינט	PUT: https // maccabi4u.co.il/patients/1
עדכון סטטוס	PUT:https // maccabi4u.co.il/patients/1/status

מיפוי Routs לרופאים:
שליפת רשימת רופאים	GET:https // maccabi4u.co.il/doctors
שליפת רופא לפי מזהה	GET:https // maccabi4u.co.il/doctors/1
הוספת רופא	POST: https// maccabi4u.co.il/doctors
עדכון רופא	PUT: https// maccabi4u.co.il/doctors/1
עדכון סטטוס	PUT:https//maccabi4u.co.il/doctors/1/status
	
מיפוי Routs לתורים:	
שליפת רשימת תורים	GET:https // maccabi4u.co.il/doctors
שליפת תור לפי מזהה	GET:https // maccabi4u.co.il/doctors/1
הוספת תור	POST: https// maccabi4u.co.il/doctors
עדכון תור	PUT: https// maccabi4u.co.il/doctors/1
מחיקת תור	DELETE: https// maccabi4u.co.il/doctors/1
