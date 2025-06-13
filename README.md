# GuroDemo – Design Patterns in Practice 🧠💻

Welcome to **GuroDemo**, an educational C# console application designed to demonstrate the practical application of classic **Design Patterns**.
This repository serves as a clean, modular base for studying and implementing patterns like Builder, Strategy, Decorator, Observer, Singleton, Command, and Factory Method in a real-world structure.

---

## 📂 Repository Structure

```
📦 GuroDemo
 ├ 📜 README.md                    # Project overview and usage
 ├ 📜 CHANGELOG.md                 # Version history and changes
 ├ 📜 ARCHITECTURE.md              # Project structure and design explanatio
 ├ 📜 TESTING.md                   # Testing strategy and plans
 ├ 📜 LICENSE                      # Project license (MIT)
 ├ 📜 CODE_OF_CONDUCT.md          # Code of Conduct for contributors
 ├ 📜 CONTRIBUTING.md             # How to contribute to the project
 ├ 📜 ONBOARDING.md               # Guide for new contributors
 ├ 📜 STYLE_GUIDE.md              # Coding standards and style guidelines
 ├ 📜 GIT_FLOW.md                 # Git flow and branch management
 ├ 📜 BRANCH_PROTECTION_RULES.md # Rules for branch protection
 ├ 📜 ROLES.md                    # Project roles and responsibilities
 ├ 📜 RELEASES.md                 # Release management guidelines
 ├ 📂 src/                         # Main application source code
 ├ 📂 tests/                       # Unit and integration tests
 ├ 📂 docs/                        # Additional documentation
 └ 📂 .github/
     ├ 📂 ISSUE_TEMPLATE/          # Templates for issues and feature requests
     ├ 📜 PULL_REQUEST_TEMPLATE.md # Pull request template
     └ 📂 workflows/               # CI/CD workflows (GitHub Actions)
```

---

## 🚀 Getting Started

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/GuroDemo.git
   cd GuroDemo
   ```

2. **Open in Visual Studio / VS Code**
   Ensure you have .NET 6 or higher installed.

3. **Run the app**
   Launch the application via `Program.cs` and follow the console instructions to simulate order creation, customer selection, and product configuration.

---

## 🧩 Design Patterns Implemented

| Pattern        | Description                                               |
| -------------- | --------------------------------------------------------- |
| Builder        | Step-by-step creation of `Customer` and `Product` objects |
| Strategy       | Dynamic price calculation based on customer type          |
| Singleton      | Single instance of `OrderSender`                          |
| Observer       | Notification system (e.g. printing, emails)               |
| Decorator      | Add product features like warranty, packaging, etc.       |
| Command        | Encapsulate item addition as executable command           |
| Factory Method | Generate customer instances based on type                 |

Each pattern is described in [`ARCHITECTURE.md`](ARCHITECTURE.md) and applied in the source code.

---

## 💠 Built-in Features

* Clean, modular, and extensible codebase
* Clear implementation of multiple design patterns
* Interactive console-based flow for learning
* CI/CD-ready structure (GitHub Actions)
* Scaffolded documentation and contribution guides

---

## 📋 Documentation Highlights

* **[ARCHITECTURE.md](ARCHITECTURE.md)** – Structural overview and component map
* **[CHANGELOG.md](CHANGELOG.md)** – Semantic version history
* **[TESTING.md](TESTING.md)** – Testing strategy and future coverage
* **[CONTRIBUTING.md](CONTRIBUTING.md)** – Guidelines for contributing code
* **[CODE\_OF\_CONDUCT.md](CODE_OF_CONDUCT.md)** – Community standards
* **[STYLE\_GUIDE.md](STYLE_GUIDE.md)** – C# style conventions used in the project
* **[RELEASES.md](RELEASES.md)** – Release process and tagging
* **[ONBOARDING.md](ONBOARDING.md)** – Setup instructions for new contributors
* **[GIT\_FLOW.md](GIT_FLOW.md)** – Git workflow explanation
* **[BRANCH\_PROTECTION\_RULES.md](BRANCH_PROTECTION_RULES.md)** – Guidelines for maintaining main/dev branches
* **[ROLES.md](ROLES.md)** – Team member responsibilities

---

## 💡 Contributing

This is a learning-oriented project. Contributions, ideas, and improvements—especially around test automation, documentation, and additional design patterns—are very welcome.
Fork the repository, create a feature branch, and open a pull request.

---

## 🤝 License

This project is licensed under the [MIT License](LICENSE).

---

## 🙋 Need Help?

Feel free to [open an issue](https://github.com/your-username/GuroDemo/issues) or start a discussion in the repository.

---

🚀 **Enjoy learning and writing clean, maintainable code with patterns!**
