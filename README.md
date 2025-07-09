"# Project-11 _ Age-Calculator" 

# 📅 Project-11: Age Calculator

## 👤 Author: Mustafa A. Ibrahim

A graphical Age Calculator built using **C#** and **Windows Forms** that calculates the user's age in various units—years, months, days, hours, and more—based on their birth date. The app demonstrates date/time manipulation and GUI programming fundamentals.

---

## 🧾 Overview

This Windows Forms application allows users to:
- Input their **birth date** via a date picker
- Instantly calculate age in multiple formats:
  - **Years, Months, Days**
  - **Total Months**
  - **Total Weeks**
  - **Total Days**
  - **Total Hours**
  - **Total Minutes**
  - **Total Seconds**
- Display the age breakdown in a clear, interactive interface
- Validate date input to ensure it is not in the future

---

## 💻 Technologies Used

- **Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Libraries:** 
  - `System.Windows.Forms` (GUI)
  - `System.DateTime`, `System.TimeSpan` (Date/Time calculations)
  - `System.ComponentModel` (Event handling)

---

## 🧩 Key Features

- 📆 **Date Picker Input**: Easily select your birth date using a calendar UI
- 📊 **Multi-Unit Output**: View your age in years, months, weeks, and more
- 🧠 **Accurate Calculation**: Considers leap years and varying month lengths
- 🖥️ **Multi-Form Architecture**: 
  - `frmAgeCalculatorScreenStart` (Start screen)
  - `frmAgeCalculatorScreen` (Main calculator interface)
- ⚠️ **Input Validation**: Prevents selection of future dates
- 🌍 **Localization Friendly**: Age output message uses Arabic ("عمرك هو...")

---

## 🚀 Installation & Setup

### Prerequisites
- Visual Studio with **.NET Desktop Development** workload

### Setup Steps

1. **Clone the Repository**
```bash
git clone https://github.com/MustafaIbrahim990/Project-11_Age-Calculator.git