# 🏗 SYSARCH32 Midterm Project - Git Workflow Integration  

## 📌 Project Overview  
This project is an MVC-based CRUD application developed as part of the SYSARCH32 midterm exam. The objective is to integrate Git and GitHub into our workflow using proper version control techniques, including branching, pull requests, issue tracking, and team collaboration.

## 🚀 Steps to Clone and Run the Application  

### **1️⃣ Clone the Repository**
```bash
git clone https://github.com/YOUR-USERNAME/YOUR-REPO.git
cd YOUR-REPO
## Git Workflow: Branching, Merging & Pull Requests
📂 1. Repository Structure
main: Stable working version

feature-*: Individual feature branches (e.g., feature-auth, feature-crud)

bugfix-*: Branches for fixing bugs

🌿 2. Creating a Feature Branch
Before starting a new feature, always create a new branch:
git checkout -b feature-name
Pushing to GitHub
git push origin feature-branch-name
Creating a Pull Request (PR)
Go to GitHub > Pull Requests

Click New Pull Request

Select feature-branch → main

Add a description of the changes

Assign a reviewer and submit for review

Reviewing & Merging
A teammate reviews the PR and requests changes if necessary.
Once approved, the branch is merged into main using:
git checkout main
git merge feature-branch-name
📌 Issue Tracking & Task Management
📋 Creating Issues
Go to GitHub > Issues > New Issue and create an issue using:

Title: Brief issue summary

Description: Details about the issue/task

Labels: (e.g., bug, enhancement, feature)

Assignee: Assign the issue to a team member

Example:

Issue: Implement User Authentication
Description: Create a login and registration system with password hashing.
Assignee: Joshua Therence Templo
Labels: enhancement, backend

🔗 Closing Issues with Commits
To automatically close an issue when committing:
git commit -m "feat(auth): implemented user login and registration, closes #5"
This will close Issue #5 when pushed to GitHub.

