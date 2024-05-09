create view bireports.vw_Test_orderdetails
as
(
SELECT DISTINCT ISNULL(od.HA_PODate,od.CROS_PODate) as date,
	 od.OrderNumber
	,od.NHMemberID
	,od.InsuranceCarrierID, od.InsuranceCarrierName
	,od.InsuranceHealthPlanID, od.InsuranceHealthPlanName
	,ISNULL(em.FirstName,m.FirstName) MemberFirstName
	, ISNULL(em.LastName,m.LastName) MemberLastName
	,m.FirstName, m.LastName, m.DataSource, m.NHLinkID
	,em.Address1
	,em.Address2
	,em.City
	,em.State
	,em.ZipCode
	,em.subscriberID InsuranceNbr
		,JSON_VALUE(o.MemberData,'$.address.address') Order_Address1
	,JSON_VALUE(o.MemberData,'$.address.city') Order_City
	,JSON_VALUE(o.MemberData,'$.address.state') Order_State
	,JSON_VALUE(o.MemberData,'$.address.zip') Order_Zip
	,JSON_VALUE(o.MemberData,'$.insurance.insuranceMemberId') Order_InsuranceNbr
	--,ISNULL(ap.AppointmentDate,ap1.AppointmentDate) TestScheduleDate
	--,hap.HAP_NUMBER
	--,em.NHLinkid, OrderNumber
	,ISNULL(od.HA_PODate,od.CROS_PODate) PODate, od.[Fitting Date] FittingDate, od.Manufacturer Brand, ISNULL(od.Left_Family,od.Right_Family) FamilyCode
	,ISNULL(od.Left_HA,od.Right_HA) ProductCode, ISNULL(od.Left_Tech_Code,od.Right_Tech_Code) TechnologyLevel
	,(ISNULL(od.Quantity,0) - ISNULL(od.QtyReturned,0)) DeviceCount, ISNULL(od.Left_Technology,od.Right_Technology) Technology
	--FROM bireports.BI_OrderDetail_Data_2021 od WITH (NOLOCK)
	from (
	       select * from bireports.BI_OrderDetail_Data_2021
	       union
		   select * from bireports.BI_OrderDetail_Data_2022
		   union
		   select * from bireports.BI_OrderDetail_Data_2020
	     ) od--WITH (NOLOCK)
		 --FROM
	--( 
	--   select * from bireports.BI_OrderDetail_Data_2021  WITH (NOLOCK)
	--   UNION ALL
	--   select * from bireports.BI_OrderDetail_Data_2022	WITH (NOLOCK)
	--) od 
join[orders].[orders]o WITH (NOLOCK) on (o.OrderID=od.OrderNumber)
join [master].[Members] m WITH (NOLOCK) ON (m.NHMemberID=o.NHMemberId)
join [provider].[MemberChartData] mcd WITH (NOLOCK) ON (o.MemberChartDataID = mcd.MemberChartDataID)
join [provider].[MemberCharts] mc WITH (NOLOCK) ON (mc.MemberChartID = mcd.MemberChartID)
LEFT JOIN elig.mstrEligBenefitData  em WITH (NOLOCK) ON (em.MasterMemberID=m.MemberID AND em.NHLinkid=m.NHLinkID AND em.FirstName=m.FirstName AND em.LastName=m.LastName
											  AND ISNULL(od.HA_PODate,od.CROS_PODate) BETWEEN em.RecordEffDate AND em.RecordEndDate
											  AND ISNULL(od.HA_PODate,od.CROS_PODate) BETWEEN em.BenefitStartDate AND em.BenefitEndDate)
where 1=1 AND od.[Status] = 'ACTIVE')