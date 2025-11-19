![Dynamic Grid Icon](https://copilot.microsoft.com/th/id/BCO.3c377a5d-4644-4839-9d24-872469214cbd.png)

🧮 Dynamic Grid Generator

A Windows Forms application written in C# that creates and displays a two-dimensional grid based on user-defined dimensions. This project is ideal for learning how to work with arrays, form controls, and data visualization using DataGridView.

---

📦 Features

- User Input:
  - Two textboxes (txtn1, txtn2) allow users to enter the number of rows and columns.
  - A button (btnshow) triggers grid generation.

- Grid Creation:
  - A two-dimensional integer array is created using the input dimensions.
  - The array is displayed in a DataGridView with matching row and column counts.

- Validation:
  - If either textbox is empty, a message box alerts the user to fill in both fields.

---

🛠 Technologies Used

- Language: C#
- Framework: .NET Framework (Windows Forms)
- IDE: Visual Studio
- UI Components: TextBox, Button, DataGridView, MessageBox

---

🚀 How to Run

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Enter values in both textboxes:
   - First textbox: number of rows.
   - Second textbox: number of columns.
5. Click the "Show" button to generate and display the grid.

---

📁 Project Structure

`
DynamicGridApp/
├── Form1.cs              // Main form with grid generation logic
├── Form1.Designer.cs     // UI layout and control definitions
├── Program.cs            // Application entry point
`

---

💡 Educational Value

This project helps you practice:

- Reading and validating user input.
- Creating and manipulating 2D arrays.
- Dynamically configuring DataGridView controls.
- Providing user feedback with message boxes.
