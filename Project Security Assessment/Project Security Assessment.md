# Security Assessment Report  
<p style="text-align: center;"># Security Assessment Report</p>

Version N.0  
May 1, 2023  
 
# Table of Contents
1.	Summary	3
  1.	Assessment Scope	3
  2.	Summary of Findings	3
  3.	Summary of Recommendations	4
2.	Goals, Findings, and Recommendations	4
  1.	Assessment Goals	4
  2.	Detailed Findings	5
  3.	Recommendations	5
3.	Methodology for the Security Control Assessment	5
  4.	Figures and Code	7
  4.1.1	Process flow of System (this one just describes the process for requesting)	7
  4.1.2	Other figure of code	7
5.	Works Cited	7
 
1.	Summary
Executive Summary Here: Describe the overall goal, method, and major findings/recommendations here. (it’s the TLDR)
1.	Assessment Scope
What tools, platforms, OSes, Browsers, and software (including your own) was tested or used in testing?
2.	Summary of Findings
Of the findings discovered during our assessment, 0 were considered High risks, 2 Moderate risks, 0 Low, and 0 Informational risks. The SWOT used for planning the assessment are broken down as shown in Figure 2.

 

Figure 1. Findings by Risk Level
Explain above and link to full table of explanation of top risks like Figure 3.


 
Figure 2. SWOT
Explain which issues were used from above SWOT (which are addressed in this assessment).
3.	Summary of Recommendations

2.	Goals, Findings, and Recommendations
1.	Assessment Goals

The purpose of this assessment was to do the following:
•	Ensure that the system was in compliance with regulations you had to deal with or any other requirements (to include the assignments themselves).
•	Determine if the application was securely maintained.
•	Etc.
2.	Detailed Findings
Ensure each vulnerability is thoroughly explained, specific risks to the continued operations are identified, and the impact of each Threat or Weakness is analyzed as a business case. Ensure these are linked to Table 1 when describing the Risk Value. This is not the fixes – it’s the description of the problems found. The fixes go in the next section (for ease of lookup using TOC) - build this off your checklist, SWOT, and risk assessments.

3.	Recommendations
Here’s where your fixes go (ensure you reference Table 2 for your ease of fix evaluation and explain why it matches that category).

3.	Methodology for the Security Control Assessment
3.1.1	Risk Level Assessment (delete this text: you don’t have to change 3.1.1)
Each Business Risk has been assigned a Risk Level value of High, Moderate, or Low. The rating is, in actuality, an assessment of the priority with which each Business Risk will be viewed. The definitions in Table 1 apply to risk level assessment values (based on probability and severity of risk). While Table 2 describes the estimation values used for a risk’s “ease-of-fix”.

Table 1 - Risk Values
Rating	Definition of Risk Rating
High Risk	Exploitation of the technical or procedural vulnerability will cause substantial harm to the business processes. Significant political, financial, and legal damage is likely to result
Moderate Risk	Exploitation of the technical or procedural vulnerability will significantly impact the confidentiality, integrity and/or availability of the system, or data. Exploitation of the vulnerability may cause moderate financial loss or public embarrassment to organization.
Low Risk	Exploitation of the technical or procedural vulnerability will cause minimal impact to operations. The confidentiality, integrity and availability of sensitive information are not at risk of compromise. Exploitation of the vulnerability may cause slight financial loss or public embarrassment
Informational	An “Informational” finding, is a risk that has been identified during this assessment which is reassigned to another Major Application (MA) or General Support System (GSS). As these already exist or are handled by a different department, the informational finding will simply be noted as it is not the responsibility of this group to create a Corrective Action Plan.
Observations	An observation risk will need to be “watched” as it may arise as a result of various changes raising it to a higher risk category. However, until and unless the change happens it remains a low risk.

Table 2 - Ease of Fix Definitions
Rating	Definition of Risk Rating
Easy	The corrective action(s) can be completed quickly with minimal resources, and without causing disruption to the system or data
Moderately Difficult	Remediation efforts will likely cause a noticeable service disruption
•	A vendor patch or major configuration change may be required to close the vulnerability
•	An upgrade to a different version of the software may be required to address the impact severity
•	The system may require a reconfiguration to mitigate the threat exposure
•	Corrective action may require construction or significant alterations to the manner in which business is undertaken
Very Difficult	The high risk of substantial service disruption makes it impractical to complete the corrective action for mission critical systems without careful scheduling
•	An obscure, hard-to-find vendor patch may be required to close the vulnerability
•	Significant, time-consuming configuration changes may be required to address the threat exposure or impact severity
•	Corrective action requires major construction or redesign of an entire business process
No Known Fix	No known solution to the problem currently exists. The Risk may require the Business Owner to:
•	Discontinue use of the software or protocol
•	Isolate the information system within the enterprise, thereby eliminating reliance on the system
In some cases, the vulnerability is due to a design-level flaw that cannot be resolved through the application of vendor patches or the reconfiguration of the system. If the system is critical and must be used to support on-going business functions, no less than quarterly monitoring shall be conducted by the Business Owner, and reviewed by IS Management, to validate that security incidents have not occurred

3.1.2    Tests and Analyses
This was completed using <list and describe any type of testing you performed here>.

3.1.3   Tools
This was completed using <list and describe any tools used for testing (include Linux Command Line commands>.

 
4.	Figures and Code
Insert any pictures here (including of major code issues or code that was used as a tool – can just screenshot and add link to github). This section must include at least 4 figures or code portions:
4.1.1	Process or Data flow of System (this one just describes the process for requesting), use-cases, security checklist, graphs, etc.
 

Describe the process flow here.
4.1.2	Other figure of code
HERE

5.	Works Cited
There are no sources in the current document.

