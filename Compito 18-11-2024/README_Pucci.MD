# Table of Contents

- [Staging Area](#staging-area)
- [Contributing](#contributing)
- [Community](#community)
- [Project Structure](#project-structure)
- [Application Infrastructure](#application-infrastructure)
- [Behind HospitalRun](#behind-hospitalRun)


# Staging Area

You can follow developments by visiting the dedicated [staging environment](https://staging.hospitalrun.io). Use `username` / `password` as credentials to access.

# Contributing

Interested in contributing to HospitalRun? There are many ways that you can get involved:
- Try the [application](https://staging.hospitalrun.io)
- Request [new features](https://github.com/HospitalRun/hospitalrun/issues/new?template=feature.md) and [report bugs](https://github.com/HospitalRun/hospitalrun/issues/new?template=bug.md)
- Write [project documentation](https://hospitalrun.readthedocs.io/)
- Contribute to the [source code](https://github.com/HospitalRun/hospitalrun/blob/master/.github/CONTRIBUTING.md)
- [Sponsor the project](https://opencollective.com/hospitalrun/contribute/sponsors-336/checkout)
- Translate text in the [application](https://staging.hospitalrun.io)

# Community

Join HospitalRun's community for discussion and ask questions: [HospitalRun's Slack Workspace](https://hospitalrun-slack.herokuapp.com)

Channels :
- **#general** - For general purpose 
- **#contributors** - For people who contribute to HospitalRun by developing features
- **#troubleshooting** - For software related issues

# Project Structure

| Submodules                                                      | Version | Progress status                                                      | Build status                                                                                                                                             | Coverage status                                                                                                                                                                              | Code quality                                                                                                                                                                                                                 |
| --------------------------------------------------------------- | --- | -------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [Frontend](https://github.com/HospitalRun/hospitalrun-frontend) | ![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/hospitalrun/hospitalrun-frontend?include_prereleases) | ![Status](https://img.shields.io/badge/Status-developing-brightgree) | [![GitHub CI](https://github.com/HospitalRun/frontend/workflows/GitHub%20CI/badge.svg)](https://github.com/HospitalRun/frontend/actions)                 | [![Coverage Status](https://coveralls.io/repos/github/HospitalRun/hospitalrun-frontend/badge.svg?branch=master)](https://coveralls.io/github/HospitalRun/hospitalrun-frontend?branch=master) | [![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/HospitalRun/hospitalrun-frontend.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/HospitalRun/hospitalrun-frontend/context:javascript) |
| [Server](https://github.com/HospitalRun/hospitalrun-server)     | ![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/hospitalrun/hospitalrun-server?include_prereleases) | ![Status](https://img.shields.io/badge/Status-developing-brightgree) | [![GitHub CI](https://github.com/HospitalRun/server/workflows/GitHub%20CI/badge.svg)](https://github.com/HospitalRun/server/actions)                     | [![Coverage Status](https://coveralls.io/repos/github/HospitalRun/hospitalrun-server/badge.svg?branch=master)](https://coveralls.io/github/HospitalRun/hospitalrun-server?branch=master)     | [![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/HospitalRun/hospitalrun-server.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/HospitalRun/hospitalrun-server/context:javascript)     |
| [Components](https://github.com/HospitalRun/components)         | ![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/hospitalrun/components?include_prereleases) | ![Status](https://img.shields.io/badge/Status-developing-brightgree) | [![GitHub CI](https://github.com/HospitalRun/components/workflows/GitHub%20CI/badge.svg)](https://github.com/HospitalRun/components/actions)             | [![Coverage Status](https://coveralls.io/repos/github/HospitalRun/components/badge.svg?branch=master)](https://coveralls.io/github/HospitalRun/components?branch=master)                     | [![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/HospitalRun/components.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/HospitalRun/components/context:javascript)                     |
| [Core](https://github.com/HospitalRun/hospitalrun-core)         | ![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/hospitalrun/hospitalrun-core?include_prereleases) | ![Status](https://img.shields.io/badge/Status-developing-brightgree) | [![GitHub CI](https://github.com/HospitalRun/hospitalrun-core/workflows/GitHub%20CI/badge.svg)](https://github.com/HospitalRun/hospitalrun-core/actions) |         | [![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/HospitalRun/hospitalrun-core.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/HospitalRun/hospitalrun-core/context:javascript)         |
| [CLI](https://github.com/HospitalRun/cli)                       | ![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/hospitalrun/cli?include_prereleases) | ![Status](https://img.shields.io/badge/Status-developing-brightgree) | [![GitHub CI](https://github.com/HospitalRun/cli/workflows/GitHub%20CI/badge.svg)](https://github.com/HospitalRun/cli/actions)                           | [![Coverage Status](https://coveralls.io/repos/github/HospitalRun/cli/badge.svg?branch=master)](https://coveralls.io/github/HospitalRun/cli?branch=master)                                   | [![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/HospitalRun/cli.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/HospitalRun/cli/context:javascript)                                   |

<em>Last Update: 2 July 2020</em>

# Application Infrastructure

A visual representation of the functionality of all HospitalRun modules and their interactions.

[<img width="1658" alt="miro" src="https://slyvi-tstorage.fra1.cdn.digitaloceanspaces.com/r198460719304_tml3365830375169_545793529045_172210184782069.png">](https://miro.com/app/board/o9J_kv4RtwE=/)

### Table of Contents
------------------------------------------------

- [Introduction](#Introduction)
- [Step by steps](#Step-by-steps)
- [What will happen next](#What-will-happen-next)
- [Our commitment](#Our-commitment)
- [Tables](#Tables)
- [Blocks od code](#Blocks-od-code)

## Reporting Security Issues
------------------------------------------------

### Introduction
------------------------------------------------

  The security od our systems is …

### Please Follow There Steps:
------------------------------------------------

1. Do not Report any details …
	- Please do not discolse ant details about the vulnerability in public forums
2. Email Us Directly
	- To report a security issue, please send an email directly to us at aaa@aaa.it
		- the conditions on which the vulnerability can be reproduced
		- Any potential impacts od the bulnerability
		- How you found the vulnerability, if you'd like to share this

### What Will Happen Next
------------------------------------------------

- **Acknowledgement:** We will acknowledge your email in 24h
- **Investigation:** Our security team will investigate the issue
- **Communication:** We will keep you informed of our progress
- **Disclosure:** Once the issue has been resolved, we will woek with you to coordinate the Disclosure od the vulnerability

### Our Commitment
------------------------------------------------

We are committed to working with security researchers and the community to make our product safer. we bla bla bla

Thank you for helping us keep our product and our users safe!

### Tables
------------------------------------------------

| **Left Columns** | **Right Columns** |
| :----------- | :------------ |
| left foo | right foo |
| left bar | right bar |
| left baz | right baz |

### Block od Code
-------------------------------------------------

``` 
parola = input("Scrivi la parola:/n")
if parola == scatola:
	print("bravo, hai azzeccato la parola")
else:
	print("hai sbagliato")
```

