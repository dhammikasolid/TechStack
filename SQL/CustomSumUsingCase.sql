
-- Input Expression
select top(5) CustCode, 
	SUM(
		case PortalModule
			when 'RM' then Amount * 0.5
			when 'FM'  then Amount * 0.1
			else 0
		end
	) CustomAmount from PortalInvoices
group by CustCode

-- Boolean Expression
select top(5) CustCode, 
	SUM(
		case 
			when PortalModule = 'RM' then Amount * 0.5
			when PortalModule = 'FM'  then Amount * 0.1
			else 0
		end
	) CustomAmount from PortalInvoices
group by CustCode


select top(5) CustCode, SUM(CustomAmount)
 from (select CustCode, PortalModule, Amount,
	CustomAmount = 
		case 
			when PortalModule = 'RM' then Amount * 0.5
			when PortalModule = 'FM'  then Amount * 0.1
			else 0
		end
	from PortalInvoices) cd
group by CustCode

select top(5)CustCode,  SUM(Amount) CustomAmount from PortalInvoices
group by CustCode
