import { NgModule } from '@angular/core';
import { Routes, RouterModule} from '@angular/router'; 
import { GanttComponent } from './components/gantt/gantt.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { ProjectsComponent } from './components/projects/projects.component';
import { PersonnelComponent } from './components/personnel/personnel.component';
import { PersonnelAddComponent } from './components/personnel/personnelAdd/personnelAdd.component';
import { ScannerComponent } from './components/scanner/scanner.component';
import { OrdersComponent } from './components/orders/orders.component';
import { QRCodeGenComponent } from './components/qr-code-generator/qr-code-gen.component';
import { LoginComponent } from './components/login/login.component';
import { AuthGuard } from './basic-gaurd/auth.gaurd';
import { QuoteComponent } from './components/quote/quote.component';
import { InvoiceComponent } from './components/invoice/invoice.component';
import { VpnComponent } from './components/vpn_passwords/vpn.component';
import { PersonnelGanttComponent } from './personnel_gantt/personnel.gantt.component';

const routes: Routes = [
    { path: '',redirectTo:'login-component', pathMatch: 'full'},
    { path: 'login-component', component: LoginComponent },
    { path: 'gantt-component', component: GanttComponent, canActivate: [AuthGuard]  },
    { path: 'inventory-component', component: InventoryComponent, canActivate: [AuthGuard]  },
    { path: 'projects-component', component: ProjectsComponent, canActivate: [AuthGuard]  },
    { path: 'personnel-component', component: PersonnelComponent, canActivate: [AuthGuard]  },
    { path: 'personnelAdd-component', component: PersonnelAddComponent, canActivate: [AuthGuard]  },
    { path: 'scanner-component', component: ScannerComponent, canActivate: [AuthGuard]  },
    { path: 'orders-component', component: OrdersComponent, canActivate: [AuthGuard]  },
    { path: 'invoice-component', component: InvoiceComponent, canActivate: [AuthGuard]  },
    { path: 'qr-code-component', component: QRCodeGenComponent, canActivate: [AuthGuard]  },
    { path: 'quote-component', component: QuoteComponent, canActivate: [AuthGuard]  },
    { path: 'vpn-component' , component: VpnComponent, canActivate: [AuthGuard] },
    { path: 'personnel.gantt-component' , component: PersonnelGanttComponent, canActivate: [AuthGuard] }
]; 


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}