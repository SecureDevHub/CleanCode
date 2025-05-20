# Contributing to SecureDevHub

Thank you for your interest in contributing to SecureDevHub! Please follow these guidelines to ensure your contribution is helpful and adheres to the project's standards.

## How to Contribute
1. **Report an issue**: Use the issue template to report bugs or propose new features.
2. **Discuss changes**: Open an issue to discuss the changes you want to make.
3. **Create a pull request (PR)**: Follow the PR template and ensure your code is well-documented and tested.

## Commit Guidelines
To maintain a clean and understandable project history, please follow these commit message guidelines:
- Use clear and descriptive commit messages.
- Follow this format: `<Type>(<Scope>): Short description (e.g., Fix: Corrects a bug in module X)`.
- Common types: `Fix`, `Feature`, `Docs`, `Refactor`, `Test`, `Chore`.

### Commit Message Format
Each commit message should be structured as follows:

[optional body]

[optional footer(s)]


#### 1. **Type**
The type indicates the purpose of the commit. Use one of the following:

- **feat**: A new feature.
- **fix**: A bug fix.
- **docs**: Documentation changes only.
- **style**: Code style changes (e.g., formatting, missing semicolons) that do not affect functionality.
- **refactor**: Code changes that neither fix a bug nor add a feature (e.g., code restructuring).
- **test**: Adding or updating tests.
- **chore**: Maintenance tasks (e.g., updating dependencies, build scripts).

#### 2. **Scope**
The scope specifies the part of the codebase affected by the change. Examples:
- `auth`, `api`, `ui`, `docs`, `tests`.

If the change affects the entire codebase, you can omit the scope.

#### 3. **Short Description**
- Use the imperative mood (e.g., "Add", "Fix", "Update").
- Keep it concise (50 characters or less).
- Avoid ending with a period.

#### 4. **Body (Optional)**
- Provide additional context or reasoning for the change.
- Explain *what* and *why*, not *how*.
- Wrap text at 72 characters per line.

#### 5. **Footer (Optional)**
- Use for breaking changes or referencing issues.
- Format for breaking changes: `BREAKING CHANGE: <description>`.
- Format for issue references: `Closes #<issue-number>`.

### Examples
#### Feature Addition
feat(auth): add OAuth2 support

Added OAuth2 authentication to the login flow. This allows users to log in using third-party providers like Google and Facebook.

Closes #42


#### Bug Fix
fix(api): handle null values in user data

Fixed a bug where null values in the user data caused the API to crash.


#### Documentation Update
docs: update README with installation instructions


#### Breaking Change
refactor(api): remove deprecated endpoints

BREAKING CHANGE: Removed the /v1/users endpoint. Use /v2/users instead.

## Code Style
- Follow the project's coding conventions.
- Use linting and automatic formatting tools (e.g., Prettier, ESLint).
- Write tests for every new feature or fix.

## Review Process
- Every PR must be reviewed by at least one other contributor.
- Ensure all tests pass before requesting a review.

Thank you for your contribution!