# EntityPrivilegeCopy
> Entity Privilege Copy Tool is an plugin for XrmToolBox. You can use this plugin to copy some entity privilege level from one entity to others base on security roles.
<!-- [![NPM Version][npm-image]][npm-url]
[![Build Status][travis-image]][travis-url]
[![Downloads Stats][npm-downloads]][npm-url] -->

![](https://github.com/ranistar/EntityPrivilegeCopy/blob/e665b9589009d8690f6181ae6df5a2dedcf3d7a1/header01.png)
***
***
![](https://github.com/ranistar/EntityPrivilegeCopy/blob/e665b9589009d8690f6181ae6df5a2dedcf3d7a1/Blank%20Main%20Form.png)


## Usage example
> Preparation:
> A solution contains the security role that you want to change. **Please make sure you have backuped the solution.**

Steps
* 1. Click <kbd>Load Data</kbd> to load the metadata, wait until the "Load end." output show in Log.
* 2. Select **Source Entity**, you can input the entity display name to filter list.
* 3. Select **Target Entity(s)**, you can select one or many entity you want, the input box is used to filter the list entities.
* 4. Select **Security Role Solution**.
* 5. Select **Copy Privilege Type**, the unselected type will be ignore during copy.
* 6. Click <kbd>Execute</kbd> to do the copy. Also if you want to see the change first, you can click <kbd>Preview</kbd> and see the log output.

## Release History
* 0.2.0
    * add a filter for target entity
    * add a security type filter
    * add log output
* 0.1.0
    * The first proper release

## Meta

Ray Gan – ganzhiyi1994@gmail.com

## Known Issue

Error when entity owner type is Organization.

Export solution button is in developing, can not work for now.

## TODO List

Add a process bar during action.
Cache metadata for better perfomance.

## Contributing
I am re-writting this plugin becasue the code is mess, so you can consider wait for the new release code or just start your own work.

<!-- Markdown link & img dfn's -->
[npm-image]: https://img.shields.io/npm/v/datadog-metrics.svg?style=flat-square
[npm-url]: https://npmjs.org/package/datadog-metrics
[npm-downloads]: https://img.shields.io/npm/dm/datadog-metrics.svg?style=flat-square
[travis-image]: https://img.shields.io/travis/dbader/node-datadog-metrics/master.svg?style=flat-square
[travis-url]: https://travis-ci.org/dbader/node-datadog-metrics
[wiki]: https://github.com/yourname/yourproject/wiki
