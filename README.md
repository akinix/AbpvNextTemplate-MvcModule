# Abp vNext Cookiecutter Template MvcModule
# Overview

[Cookiecutter](https://github.com/audreyr/cookiecutter) is a popular Open Source templating engine that lets experts easily create highly customizable templates to help other users get started on a project. .

`Cookiecutter` is integrated vs2017. you can create a project directly in vs2017 using the `Cookiecutter ` template.

Using `Cookiecutter` to create `Abp vNext` projects is faster,  and supports updates if the templates has been modified. project should be created offline when the template has already been cloned.

> you can also download projects from [Abp vNext](Https://abp.io/) .



![create_project_use_cookiecutter](doc/img/create_project_use_cookiecutter.png)

# Usage

## Prerequisites

the directory or file name in this template looks like this `{{cookiecutter.cname}}.{{cookiecutter.pname}}.Application`.  

the length of the name has been changed very long, but in windows, the length of full path is limited to 260 characters.   

### Edit Group Policy

- Open Group Policy Editor (Press Windows Key and type gpedit.msc and hit Enter key.
- Navigate to the following directory:  Local Computer Policy > Computer Configuration > Administrative Templates > System > Filesystem > NTFS.
- Click Enable NTFS long paths option and enable it.

### Edit Git

- run the `git bash` command

  ```shell
  git config --system core.longpaths true
  ```



## Install Template

- open VS2017,  click `File`-`New`-`From Cookiecutter...`,  open side bar  `Cookiecutter`

  ![create_project_use_cookiecutter](doc/img/create_project_use_cookiecutter.png)


- input `https://github.com/akinix/AbpVnextTemplate-MvcModule.git`, click`Search`

  ![side_bar_start](doc/img/side_bar_start.png)

- if first download template using `Cookiecutter`,  need to install some dependencies for `Cookiecutter`. 

  ![cookiecutter_vs_install](doc/img/cookiecutter_vs_install.png)

- get the result for search. click `Next`.

  ![install_template](doc/img/install_template.png)

- the repository will be clone into `C:\Users\youname\.cookiecutters\AbpVnextTemplate-MvcModule`.

  ![install_template_success](doc/img/install_template_success.png)

  ![install_template_logs](doc/img/install_template_logs.png)



## Create Project

Choosing the template `AbpvNextTemplate-MvcModule`, and hitting next clones the repository and takes you to a form where you can enter values for template variables specified in the template’s `cookiecutter.json` file.

You can also choose the location where you would like the project folder to be created. For this `Abp vNext  MvcModule` project, you specify our desired `cn` and `pn` (**order to reduce the length of path**).

- cn: company name 
- pn: project name

![create_project](doc/img/create_project.png)

Click `Creage and Open Folder` to generate project files. Once generated, you can choose to open it in the Solution Explorer. Here’s our newly created project open in it. 

![create_project_success](doc/img/create_project_success.png)

## Update Template

you can update template when the repository has new version.

-  check for updates for the installed templates anytime by right clicking on a template and choosing the option in the context menu.

  ![check_update](doc/img/check_update.png)

  ![update](doc/img/update.png)