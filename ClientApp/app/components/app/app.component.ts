import { Component } from '@angular/core';
import { TrunkService } from "../trunks/trunk.service";

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [TrunkService]
})
export class AppComponent {
}
