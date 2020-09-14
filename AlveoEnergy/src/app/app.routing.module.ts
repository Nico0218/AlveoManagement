import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router'; 
import { GanttComponent } from './components/gantt/gantt.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { ProjectsComponent } from './components/projects/projects.component';
import { PersonnelComponent } from './components/personnel/personnel.component';
import { PersonnelAddComponent } from './components/personnel/personnelAdd/personnelAdd.component';
import { ScannerComponent } from './components/scanner/scanner.component';
import { OrdersComponent } from './components/orders/orders.component';
import { InvoiceComponent } from './components/invoice/invoice.component';
import { QRCodeGenComponent } from './components/qr-code-generator/qr-code-gen.component';

const routes: Routes = [
    { path: 'gantt-component', component: GanttComponent },
    { path: 'inventory-component', component: InventoryComponent },
    { path: 'projects-component', component: ProjectsComponent },
    { path: 'personnel-component', component: PersonnelComponent },
    { path: 'personnelAdd-component', component: PersonnelAddComponent },
    { path: 'scanner-component', component: ScannerComponent },
    { path: 'orders-component', component: OrdersComponent },
    { path: 'invoice-component', component: InvoiceComponent },
    { path: 'qr-code-component', component: QRCodeGenComponent }
]; 


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}