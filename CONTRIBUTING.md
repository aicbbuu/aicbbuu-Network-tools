# 贡献指南

欢迎为本项目贡献代码、报告 Bug 或提出功能建议。

## 报告 Bug

在 [Issues](https://github.com/aicbbuu/aicbbuu-Network-tools/issues) 页面新建 Issue，请包含：

- 复现步骤
- 期望行为 vs 实际行为
- 系统环境（Windows 版本 / .NET 版本）
- 截图（如有）

## 提交代码

1. Fork 本仓库
2. 从 `main` 分支创建特性分支（`git checkout -b feature/xxx`）
3. 提交改动（`git commit -m "feat: xxx"`）
4. 推送到你的 Fork（`git push origin feature/xxx`）
5. 在 GitHub 上发起 Pull Request

## 提交信息规范

使用 [Conventional Commits](https://www.conventionalcommits.org/) 格式：

- `feat:` 新功能
- `fix:` Bug 修复
- `docs:` 文档变更
- `refactor:` 重构
- `test:` 测试相关
- `chore:` 构建/工具相关

## 开发环境

- .NET 8 SDK
- Windows 10/11（目标平台 win-x64）
- Visual Studio 2022 / Rider / VS Code

## 代码风格

- 遵循现有代码风格
- 提交前确保 `dotnet build` 通过
- 不要引入未使用的依赖
