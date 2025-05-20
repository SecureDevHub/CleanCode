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
   - Merge the release branch into `main` and `develop`:
     ```bash
     git checkout main
     git merge release/<version>
     git checkout develop
     git merge release/<version>
     ```

4. **Tag the Release**
   - Create a version tag:
     ```bash
     git tag -a v<version> -m "Release version <version>"
     git push origin v<version>
     ```

5. **Publish the Release**
   - Create a new release on GitHub and attach the release notes.

## Hotfix Workflow
- For critical fixes, create a hotfix branch from `main`:
  ```bash
  git checkout main
  git pull
  git checkout -b hotfix/<name>
  ```
Apply the fix, test it, and merge it into both main and develop.

## Release Notes
Each release should include:

- A summary of new features.
- A list of bug fixes.
- Any breaking changes.
- Acknowledgments for contributors (if applicable).

# Release Note Template
## Release Notes - [Product/Project Name]

**Version:** [Version Number]  
**Release Date:** [Date]  

---

### Key Highlights
- [Brief description of the main new features or improvements]
- [Example: "Added the ability to export reports in PDF format."]

---

### Improvements
- [Description of minor improvements or optimizations]
- [Example: "Optimized the dashboard loading speed."]

---

### Bug Fixes
- [Description of resolved bugs]
- [Example: "Fixed an issue causing the application to crash during login."]

---

### Security Updates
- [Description of any security-related updates]
- [Example: "Updated the OpenSSL library to the latest version to mitigate known vulnerabilities."]

---

### Additional Notes
- [Any additional information, such as deprecations, API changes, or important notices]
- [Example: "The X feature has been deprecated and will be removed in version 2.0."]

---

### Upgrade Instructions
- [Steps or requirements to upgrade to the new version]
- [Example: "Ensure to back up the database before proceeding with the upgrade."]
