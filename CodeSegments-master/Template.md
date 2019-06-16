# 设计模式

MVP

## View

视图层。

重要成员变量：

	1. control: 该view负责的控件
	2. presenter: 该view的presenter

## Presenter

表现层，适配层。

重要成员变量：
	
	1. View： 该presenter负责的view

将view传给构造函数，构造函数中将view分配给View，并将presenter与view双向绑定。

## Model

数据模型层。


## Model与Entity的区别

Model是每个视图对应的数据模型，Entity是数据实体。
