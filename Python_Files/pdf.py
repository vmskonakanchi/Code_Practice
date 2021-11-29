import  PyPDF2
f = open(r"C:\Users\vmsko\OneDrive\Desktop\Work/Vamsi_Koanakanchi Python_Completion.pdf" , "rb")
pdfreader = PyPDF2.PdfFileReader(f)
print(pdfreader.getPage(0).extractText())