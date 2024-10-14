ReadMe 

CMCS_APP2.0 (LectraClaim System) - Part 2 Implementation
Overview
The LectraClaim System is designed to facilitate the submission, approval, and tracking of monthly claims by Independent Contractor lecturers. This is the second part of the project, where additional functionalities are implemented to provide a more interactive and complete experience. This part introduces claim submission, approval, file uploading, and claim status tracking.

Features Implemented:
Claim Submission: Lecturers can now submit their monthly claims using a simple and intuitive form.
Claim Approval: Programme Coordinators and Academic Managers can review and either approve or reject claims.
File Uploading: Lecturers can upload supporting documents (.pdf, .docx, .xlsx) when submitting claims.
Claim Status Tracking: Lecturers can track the status of their claims as they move through the approval process.
Modern User Interface (UI): The application has been updated with a modern design, including a blue-themed background and flat, stylish buttons for better user experience.
How to Use the Application
1. MainWindow:
Homepage:
The home screen displays three main options for users:
Submit a Claim: Redirects to the form where lecturers can submit claims.
Approve Claims: Opens the approval page for coordinators and managers to approve or reject claims.
View Claim Status: Allows lecturers to check the current status of their submitted claims.
2. Submitting a Claim:
Click on the "Submit a Claim" button to access the submission form.
Fill in the required fields, including:
Hours Worked: Enter the number of hours worked for the month.
Hourly Rate: Enter the hourly rate agreed upon.
Additional Notes: Any extra information relevant to the claim can be added here.
Upload supporting documents (PDF, DOCX, XLSX) by clicking on the "Upload" button.
After filling in the details, click "Submit" to submit the claim.
3. Approving Claims:
Programme Coordinators and Academic Managers can access pending claims by clicking on "Approve Claims".
Each claim will display the details submitted by the lecturer, including hours worked, hourly rate, and uploaded documents.
To approve or reject a claim, simply click the "Approve" or "Reject" button next to each claim.
Once a claim is approved or rejected, its status will be updated.
4. Tracking Claim Status:
Lecturers can view the current status of their submitted claims by clicking "View Claim Status".
Claims will display a status such as "Pending", "Approved", or "Rejected".
The status updates in real-time as claims are reviewed by coordinators or managers.
Technology Stack
WPF (Windows Presentation Foundation): The app uses WPF for the user interface to create a modern and responsive design.
C# .NET Core: The backend logic for handling form submissions, file uploads, and status updates is written in C#.
Version Control: The project is versioned using GitHub. Ensure you regularly push commits as changes are made.
Key Considerations:
File Upload Restrictions: Only common file types (.pdf, .docx, .xlsx) are allowed, and there’s a size limit of 10MB per file.
Error Handling: The application includes basic error handling to ensure a smooth user experience. Meaningful error messages will be shown if something goes wrong, such as missing fields or invalid file formats.
User Interface: The UI has been designed with a modern, minimalist approach. It features a blue color scheme with responsive buttons and user-friendly navigation.
Getting Started
To use the LectraClaim system:

Clone the repository from GitHub.
Open the project in Visual Studio.
Run the application to view the main window and navigate through the features.
Version Control
For this part of the project, ensure to regularly commit your changes with descriptive messages. At least 5 commits are expected during the implementation of this part, focusing on different milestones, such as claim submission form, file upload functionality, and approval mechanisms.

Future Improvements
Real-time notifications for lecturers when a claim is approved or rejected.
Further customization of the UI to improve usability and accessibility.
Secure authentication and role-based access control to protect sensitive data and restrict access to certain users.
Conclusion
This part of the LectraClaim System focuses on bringing interactivity and core functionalities like claim submission, approval, and tracking to life. The system is designed to be easy to use while ensuring accuracy and transparency in the claim process.
CMCS_APP2.0 FOR PROG6212 POE PART 2 BY ST10021922 
