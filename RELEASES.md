# Release Management

This document outlines the process for managing releases and versioning in the project.

## Versioning Policy
We follow **Semantic Versioning** (`MAJOR.MINOR.PATCH`):
- **MAJOR**: Introduces breaking changes.
- **MINOR**: Adds new features in a backward-compatible manner.
- **PATCH**: Fixes bugs or makes small improvements.

Example: `v1.2.3`
- `1`: Major version.
- `2`: Minor version.
- `3`: Patch version.

## Release Workflow
1. **Prepare the Release**
   - Ensure all features and fixes are merged into the `develop` branch.
   - Create a release branch:
     ```bash
     git checkout develop
     git pull
     git checkout -b release/<version>
     ```

2. **Test the Release**
   - Run all tests and ensure the code is stable.
   - Perform manual testing if necessary.

3. **Finalize the Release**
   - Update the version number in the codebase (e.g., `package.json`, `pyproject.toml`, etc.).
   - Update the `CHANGELOG.md` with the new release details.
   - Open pull request to main 

4. **Tag the Release**
   - Create a version tag:
     ```bash
     git tag -a v<version> -m "Release version <version>"
     git push origin v<version>
     ```

## Hotfix Workflow
- For critical fixes, create a hotfix branch from `main`:
  ```bash
  git checkout main
  git pull
  git checkout -b hotfix/<name>
  ```
Apply the fix, test it, and merge it into both main and develop.
