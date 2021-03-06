﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    <xsl:template match="/ADIF">
        <fo:root xmlns:fo="http://www.w3.org/1999/XSL/Format" xmlns="http://www.w3.org/1999/xhtml">
            <fo:layout-master-set>
                <fo:simple-page-master margin-top="0mm" margin-bottom="0mm" margin-left="0mm" margin-right="0mm" page-width="140mm" page-height="90mm" master-name="simplePageLayout">
                    
                    <!-- Print Preview : Yes / No -->
                     <xsl:choose>
                         <xsl:when test="normalize-space(QSO/PRINT_PREVIEW) = 'Y'">
                            <fo:region-body region-name="xsl-region-body" column-gap="0.25in" absolute-position="absolute" background-image="SP7DAU.jpg"/>                         </xsl:when>
                         <xsl:otherwise>
                            <fo:region-body region-name="xsl-region-body" column-gap="0.25in" absolute-position="absolute" />
                         </xsl:otherwise>
                    </xsl:choose>

                    <fo:region-before region-name="xsl-region-before" display-align="after" padding="0" border-width="0"/>
                    <fo:region-after region-name="xsl-region-after" display-align="before" padding="0" border-width="0"/>
                </fo:simple-page-master>
                <fo:page-sequence-master master-name="default-sequence">
                    <fo:repeatable-page-master-reference master-reference="simplePageLayout" />
                </fo:page-sequence-master>
            </fo:layout-master-set>
            <fo:page-sequence master-reference="default-sequence">
                <fo:flow flow-name="xsl-region-body" font-family="Arial">
                    <fo:block-container>
                        <!-- TO RADIO -->
                        <fo:block-container position="absolute" top="8mm" left="87mm" text-align="center" height="20pt" width="130pt">
                            <fo:block font="20pt Arial"><xsl:value-of select="QSO/CALL" /></fo:block>
                        </fo:block-container>
                        
                        <!-- QSL VIA -->
                         <xsl:choose>
                             <xsl:when test="normalize-space(QSO/QSL_VIA) != ''">
                                 <fo:block-container position="absolute" top="23mm" left="87mm" text-align="center" height="20pt" width="130pt">
                                     <fo:block font="20pt Arial"><xsl:value-of select="QSO/QSL_VIA" /></fo:block>
                                 </fo:block-container>
                             </xsl:when>
                        </xsl:choose>
                        
                        <!-- PREFIX -->
                        <xsl:choose>
                            <xsl:when test="normalize-space(QSO/PREFIX) != ''">
                                <fo:block-container position="absolute" top="8mm" left="56mm" height="20pt" width="36pt">
                                    <fo:block font="20pt Arial" text-align="right"> <xsl:value-of select="QSO/PREFIX" /></fo:block>
                                </fo:block-container>
                            </xsl:when>
                        </xsl:choose>
                        
                        
                        <!-- SUFIX -->
                        <xsl:choose>
                            <xsl:when test="normalize-space(QSO/SUFIX) != ''">
                            <fo:block-container position="absolute" top="6mm" left="62mm" height="24pt">
                                    <fo:block font="24pt Arial"><xsl:text>/</xsl:text> <xsl:value-of select="QSO/SUFIX" /></fo:block>
                            </fo:block-container>
                            </xsl:when>
                        </xsl:choose>
                        
                        <!-- 2Way QSO or SWL -->
                        <xsl:choose>
                            <!--  SWL -->
                            <xsl:when test="normalize-space(QSO/SWL) = '1'">
                                <fo:block-container position="absolute" top="35.5mm" left="53.5mm">
                                    <fo:block font="14pt Arial"><xsl:text>x</xsl:text></fo:block>
                                </fo:block-container>
                            </xsl:when>
                            <xsl:otherwise>
                                <!-- 2Way -->
                                <fo:block-container position="absolute" top="35.5mm" left="5.5mm">
                                    <fo:block font="14pt Arial"><xsl:text>x</xsl:text></fo:block>
                                </fo:block-container>
                            </xsl:otherwise>
                        </xsl:choose>
                        
                        <!-- QSL PSE / TNX -->
                        <xsl:choose>
                            <!-- TNX -->
                            <xsl:when test="normalize-space(QSO/QSL_RCVD) = 'Y'">
                                <fo:block-container position="absolute" top="64mm" left="36mm">
                                    <fo:block font="12pt Arial"><xsl:text>x</xsl:text></fo:block>
                                </fo:block-container>
                            </xsl:when>
                            <!--  PSE --> 
                            <xsl:otherwise>
                                <fo:block-container position="absolute" top="64mm" left="5.5mm">
                                    <fo:block font="12pt Arial"><xsl:text>x</xsl:text></fo:block>
                                </fo:block-container>
                            </xsl:otherwise>
                        </xsl:choose>
                        
                        
                        <!-- QSO DATE -->
                        <fo:block-container position="absolute" top="50mm" left="7mm">
                            <fo:block font="14pt Arial">
                                <xsl:value-of select="QSO/DATE_DD" />
                                <xsl:text>&#160;&#160;&#160;</xsl:text>
                                <xsl:value-of select="QSO/DATE_MM" />
                            </fo:block>
                        </fo:block-container>
                        <fo:block-container position="absolute" top="51mm" left="26mm">                                
                            <fo:block font="10pt Arial">
                                <xsl:value-of select="QSO/DATE_YYYY" />
                            </fo:block>
                        </fo:block-container>
                        <fo:block-container position="absolute" top="50mm" left="42mm">
                            <fo:block font="14pt Arial">
                                <xsl:value-of select="QSO/TIME" />
                            </fo:block>
                        </fo:block-container>
                        

                        <!-- QSO MHz / Band -->
                        <fo:block-container position="absolute" top="50mm" left="65mm" text-align="center" height="14pt" width="65pt">
                            <fo:block font="14pt Arial">
                              <xsl:choose>
                                <xsl:when test="normalize-space(QSO/FREQ) != ''">
                                    <xsl:value-of select="QSO/FREQ" />
                                </xsl:when>
                               <xsl:otherwise>
                                    <xsl:value-of select="QSO/BAND" />
                               </xsl:otherwise>
                              </xsl:choose>
                            </fo:block>
                        </fo:block-container>
                        
                        <!-- QSO Mode -->
                        <fo:block-container position="absolute" top="50mm" left="92mm" text-align="center" height="14pt" width="60pt">
                            <fo:block font="12pt Arial">
                                    <xsl:value-of select="QSO/MODE" />
                            </fo:block>
                        </fo:block-container>

                        <!-- QSO RST Sent -->
                        <fo:block-container position="absolute" top="50mm" left="118mm" text-align="center" height="14pt" width="45pt">
                            <fo:block font="14pt Arial">
                                <xsl:value-of select="QSO/RST_SENT" />
                            </fo:block>
                        </fo:block-container>
                                                                 
                        <!-- QSO Remarks -->
                        <fo:block-container position="absolute" top="74mm" left="4mm" text-align="left" font-style="italic" height="40pt" width="125pt">
                            <fo:block font="10pt Arial">
                                <xsl:value-of select="QSO/REMARKS" />
                            </fo:block>
                        </fo:block-container>
                    
                         <!-- TRX / TX_PWR -->
                          <fo:block-container position="absolute" top="26mm" left="5mm" text-align="left" height="9pt" width="120pt">
                            <fo:block font="10pt Arial">
                                  <xsl:choose>
                                    <xsl:when test="normalize-space(QSO/TRX) != '' and  normalize-space(QSO/TX_PWR) != ''">
                                        <xsl:value-of select="QSO/TRX" /><xsl:text> ( </xsl:text><xsl:value-of select="QSO/TX_PWR" /><xsl:text> )</xsl:text>
                                    </xsl:when>
                                    <xsl:when test="normalize-space(QSO/TRX) != '' and  normalize-space(QSO/TX_PWR) = ''">
                                        <xsl:value-of select="QSO/TRX" />
                                    </xsl:when>
                                    <xsl:when test="normalize-space(QSO/TRX) = '' and  normalize-space(QSO/TX_PWR) != ''">
                                          <xsl:value-of select="QSO/TX_PWR" />
                                    </xsl:when>
                                       <xsl:otherwise>
                                        <xsl:text></xsl:text>
                                       </xsl:otherwise>
                                  </xsl:choose>
                            </fo:block>
                        </fo:block-container>
                    
                        <!-- ANT -->
                         <fo:block-container position="absolute" top="30mm" left="5mm" text-align="left" height="9pt" width="140pt">
                            <fo:block font="10pt Arial">
                                  <xsl:text>Antenna : </xsl:text>
                                  <xsl:choose>
                                    <xsl:when test="normalize-space(QSO/TRX) != ''">
                                        <xsl:value-of select="QSO/ANT" />
                                    </xsl:when>
                                    <xsl:otherwise>
                                        <xsl:text></xsl:text>
                                    </xsl:otherwise>
                                  </xsl:choose>
                            </fo:block>
                        </fo:block-container>
                    </fo:block-container>
                </fo:flow>
            </fo:page-sequence>
        </fo:root>
    </xsl:template>
</xsl:stylesheet>