<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>Application Model</name>
  <className>ApplicationModel1</className>
  <objects>
    <object technology="Mobile" type="Application">
      <name>Calculator</name>
      <codeName>CalculatorApplication</codeName>
      <identification>
        <properties>
          <property name="Identifier" type="string">com.android2.calculator3</property>
          <property name="IsPackaged" type="boolean">false</property>
        </properties>
      </identification>
      <children>
        <object technology="Mobile" type="Button">
          <name>0</name>
          <codeName>Zero</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">0</property>
              <property name="ClassName" type="string">Button</property>
              <property name="MobileCenterIndex" type="int">25</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>+</name>
          <codeName>Plus</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">+</property>
              <property name="AccessibilityId" type="string">plus</property>
              <property name="ClassName" type="string">Button</property>
              <property name="MobileCenterIndex" type="int">30</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>7</name>
          <codeName>Seven</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">7</property>
              <property name="ClassName" type="string">Button</property>
              <property name="MobileCenterIndex" type="int">15</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="UiObject">
          <name>MobileObject</name>
          <codeName>MobileObjectUiObject</codeName>
          <identification>
            <properties>
              <property name="ClassName" type="string">View</property>
              <property name="MobileCenterIndex" type="int">10</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>