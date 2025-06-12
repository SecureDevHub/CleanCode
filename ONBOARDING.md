# ONBOARDING GUIDE
<!-- da modificare per c# e vs e approfondire gli unit test -->
Welcome to the project! We're excited to have you on board. This guide will help you set up your environment, understand our contribution process, and get started with your first contribution.

---

## Table of Contents
1. [Project Overview](#project-overview)
2. [Setting Up Your Environment](#setting-up-your-environment)
3. [Branching and Workflow](#branching-and-workflow)
4. [Submitting a Pull Request](#submitting-a-pull-request)
5. [Code Style and Guidelines](#code-style-and-guidelines)
6. [Testing](#testing)
7. [Getting Help](#getting-help)

---

## Project Overview

CleanCode is a learning-focused repository built to explore and apply object-oriented design principles using C# and the .NET platform. It simulates different type of simplified real-world applications, where design patterns are applied to different software scenarios.

🔍 Purpose
- To provide a hands-on environment for understanding how design patterns work.
- To promote clean code practices and SOLID principles.

🛠️ Key Technologies
- C# / .NET 6+ – Core programming environment

🎯 Vision & Goals
- Demonstrate clean implementations of key design patterns.
- Maintain clarity and accessibility for learners at all levels.
---

## Setting Up Your Environment

Follow these steps to set up your development environment:

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/your-organization/your-repo.git
   cd your-repo
   ```

2. **Install Visual Studio IDE**  
   Make sure you have Visual Studio IDE installed.

3. **Run the Application**  
   Start the application locally with Visual Studio. Dependencies are automatically installed at first startup.

---

## Branching and Workflow

We follow the **Gitflow Workflow**. Follow the guidelines: GIT_FLOW.md

---

## Submitting a Pull Request

1. **Open a Pull Request**  
   Go to the repository on GitHub and open a pull request (PR) from your branch to the `main` branch.

2. **Follow the PR Template**  
   Fill out the pull request template, including:
   - A description of the changes.
   - Any related issues or tickets.
   - Steps to test your changes.

3. **Request Reviews**  
   Add reviewers to your PR and address any feedback promptly.

4. **Merge the PR**  
   Once approved, your PR will be merged by a maintainer.

---

## Code Style and Guidelines

To maintain consistency, follow these guidelines:

- **Code Style**: Use [Prettier](https://prettier.io/) or [Black](https://black.readthedocs.io/) for formatting.
- **Linting**: Run the linter before committing, or simply use SonarLint IDE extension to receive warnings during development.
- **Documentation**: Update documentation for any new features or changes.

---

## Testing

All contributions must include tests. Here's how to write and run tests:

1. **Write Tests**  
   Add unit tests for your changes in the appropriate test files.

2. **Run Tests Locally**  
   Ensure all tests pass before submitting your PR:
   ```bash
   npm test
   # or for Python
   pytest
   ```

3. **Check Coverage**  
   Verify that your changes maintain or improve test coverage.

---

## Getting Help

If you have any questions or run into issues, feel free to reach out:

- **GitHub Issues**: Open an issue with the `question` label.
- **Documentation**: Check the Wiki for more details.

---

Thank you for contributing! We're excited to see what you'll build.
