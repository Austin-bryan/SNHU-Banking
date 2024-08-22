# SNHU Banking Application

## Overview
SNHU Banking is a comprehensive banking application built using C# and Windows Forms (WinForms). The application manages various types of bank accounts, including Checking, Savings, and CDs, providing a robust and user-friendly interface for handling everyday banking needs.

## Features
### Dynamic UI Updates

The UI is designed to update dynamically in response to user actions. This includes real-time updates to account balances, YTD (Year-to-Date) totals, and visual elements like the pie chart.

### Custom Drop-Down Menu

A custom drop-down menu has been implemented to handle arbitrarily nested items. This menu is consistent with the overall theme and vision of the application, ensuring a cohesive user experience. It supports categories and items, allowing for a hierarchical selection process that is both intuitive and visually appealing.

### Custom Pie Chart

The application features a custom pie chart that visually represents the distribution of account balances across different categories. The pie chart dynamically updates as account balances change, providing real-time feedback to the user.

### Account Management

Users can manage multiple accounts, with support for three distinct types of accounts:
- Checking Accounts
- Savings Accounts
- Certificates of Deposit (CDs)
The application ensures that each account type is visually distinguished, with tailored themes and controls to match the specific needs of the account type.

## Key Components
#### 1. Account Category Control
Manages and displays all bank accounts of a certain category.
Handles the creation of new accounts and updates the UI to reflect any changes in balances or YTD values.
#### 2. Balance Preview
A UI component that displays the balance and other details of an account in the pie chart display. It updates dynamically in response to balance changes.
#### 3. Account Page
A detailed view of a single bank account. Allows users to view transactions and perform operations such as withdrawals and deposits.
#### 4. Bank Account
The core data structure representing a bank account. Handles transactions, balance updates, and interest calculations.
#### 5. Layered ComboBox
A custom drop-down menu that supports categories and nested items, providing a visually consistent and intuitive selection interface.
#### 6. New Account Form
Allows users to create a new bank account, providing a streamlined interface for entering account details and initializing the account.
