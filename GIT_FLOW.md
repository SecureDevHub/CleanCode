# Git Flow Workflow

This document describes the Git Flow workflow used in this project.

## Branch Types
1. **Main Branch (`main`)**
   - Contains the latest stable release.
   - Protected branch: no direct commits allowed.

2. **Develop Branch (`develop`)**
   - Contains the latest development state.
   - All new features and bug fixes are merged here before release.

3. **Feature Branches (`feature/<name>`)**
   - Used for developing new features.
   - Branch off from `develop`.
   - Merge back into `develop` when complete.

4. **Release Branches (`release/<version>`)**
   - Used to prepare a new release.
   - Branch off from `develop`.
   - Merge into both `main` and `develop` after release.

5. **Hotfix Branches (`hotfix/<name>`)**
   - Used for critical fixes to the production code.
   - Branch off from `main`.
   - Merge into both `main` and `develop` after the fix.
